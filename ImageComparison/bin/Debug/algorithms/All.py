from imutils.paths import list_images     
from skimage.metrics import structural_similarity

import cv2
import sys
import pickle
import os

from database.Database import createDb
from database.Database import setUpdatedData

def getSift(bf, des1, des2, kp1, kp2):
    # BFMatcher with default params
    matches = bf.knnMatch(des1,des2, k=2)

    good_points = []
    for m, n in matches:
         if m.distance < 0.82 * n.distance or n.distance < 0.82 * m.distance:
            good_points.append(m)

    # Define how similar they are
    number_keypoints = 0
    if len(kp1) >= len(kp2):
        number_keypoints = len(kp1)
    else:
        number_keypoints = len(kp2)

    res = len(good_points) / number_keypoints

    return res

#-----------MAIN-----------

imageA = sys.argv[1]
imageBDir = sys.argv[2]
path = sys.argv[3]

#SIFT
nameImageA = os.path.basename(imageA)
desPathA = path + "\\algorithms\\cpickleFiles\\Sift\\" + os.path.splitext(nameImageA)[0] + "_des.cpickle"
desPathA_reader = open(desPathA, 'rb') 
des1 = pickle.load(desPathA_reader)

kpPathA = path + "\\algorithms\\cpickleFiles\\Sift\\" + os.path.splitext(nameImageA)[0] + "_kp.cpickle"
kpPathA_reader = open(kpPathA, 'rb') 
index = pickle.load(kpPathA_reader)
kp1 = []

for point in index:
    temp = cv2.KeyPoint(x=point[0][0],y=point[0][1],_size=point[1], _angle=point[2], _response=point[3], _octave=point[4], _class_id=point[5]) 
    kp1.append(temp)

bf = cv2.BFMatcher()


#SSIM
nameImageA_ssim = path + "\\algorithms\\cpickleFiles\\SSIM\\" + os.path.splitext(nameImageA)[0] + ".cpickle"
ImageA_reader = open(nameImageA_ssim, 'rb') 
ImageA = pickle.load(ImageA_reader)

#HISTOGRAM
nameImageAHist = path + "\\algorithms\\cpickleFiles\\Histograms\\" + os.path.splitext(nameImageA)[0] + ".cpickle"
histOfA_reader = open(nameImageAHist, 'rb') 
histOfA = pickle.load(histOfA_reader)


conn = createDb(path + "\\algorithms\\database\\Database.db")
c = conn.cursor()

for imagePath in list_images(imageBDir):
    #SIFT
    nameImageB = os.path.basename(imagePath)
    desPathB = path + "\\algorithms\\cpickleFiles\\Sift\\" + os.path.splitext(nameImageB)[0] + "_des.cpickle"
    desPathB_reader = open(desPathB, 'rb') 
    des2 = pickle.load(desPathB_reader)

    kpPathB = path + "\\algorithms\\cpickleFiles\\Sift\\" + os.path.splitext(nameImageB)[0] + "_kp.cpickle"
    kpPathB_reader = open(kpPathB, 'rb') 
    index2 = pickle.load(kpPathB_reader)
    kp2 = []

    for point2 in index2:
        temp2 = cv2.KeyPoint(x=point2[0][0],y=point2[0][1],_size=point2[1], _angle=point2[2], _response=point2[3], _octave=point2[4], _class_id=point2[5]) 
        kp2.append(temp2)   

    sift = getSift(bf, des1, des2, kp1, kp2)

    #SSIM
    nameImageB_ssim = path + "\\algorithms\\cpickleFiles\\SSIM\\" + os.path.splitext(nameImageB)[0] + ".cpickle"  #IMG_005.jpg -> IMG_005.cpickle
    ImageB_reader = open(nameImageB_ssim, 'rb') 
    ImageB = pickle.load(ImageB_reader)

    (ssim, diff) = structural_similarity(ImageA, ImageB, full=True)
    diff = (diff * 255).astype("uint8")

    #HISTOGRAM
    
    nameImageBHist = path + "\\algorithms\\cpickleFiles\\Histograms\\" + os.path.splitext(nameImageB)[0] + ".cpickle"  #IMG_005.jpg -> IMG_005.cpickle
    histOfB_reader = open(nameImageBHist, 'rb') 
    histOfB = pickle.load(histOfB_reader)

    hist = cv2.compareHist(histOfA, histOfB, 0)

    res = (sift*25 + ssim*35 + hist*40)/100

    setUpdatedData(conn, imagePath, int(res*100))

conn.close()
print("OK")
