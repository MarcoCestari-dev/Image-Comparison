# import the necessary packages
from imutils.paths import list_images
import pickle
import cv2
import os
import sys


#use list_images to grab the image paths and loop over them

dirImages = sys.argv[1]
exePath = sys.argv[2]

sift=cv2.SIFT_create(6000)

for imagePath in list_images(dirImages):

    image = cv2.imread(imagePath)
    image = cv2.cvtColor(image,cv2.COLOR_BGR2GRAY)
    base = os.path.basename(imagePath)

    kp, desc = sift.detectAndCompute(image,None)
    
    keypoint = []
    for point in kp:
        temp = (point.pt, point.size, point.angle, point.response, point.octave, point.class_id)
        keypoint.append(temp)

    filename = exePath + "\\algorithms\\cpickleFiles\\SIFT\\" + os.path.splitext(base)[0] + "_kp.cpickle"
    file_pi = open(filename, 'wb') 
    pickle.dump(keypoint, file_pi)
    file_pi.close()

    filename = exePath + "\\algorithms\\cpickleFiles\\SIFT\\" + os.path.splitext(base)[0] + "_des.cpickle"
    file_pi = open(filename, 'wb') 
    pickle.dump(desc, file_pi)
    file_pi.close()


print("OK, Completato")

