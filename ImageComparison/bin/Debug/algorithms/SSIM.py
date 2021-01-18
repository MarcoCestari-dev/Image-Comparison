from imutils.paths import list_images     
from skimage.metrics import structural_similarity

import pickle
import sys
import os

from database.Database import createDb
from database.Database import setUpdatedData

#-----------MAIN-----------
imageA = sys.argv[1]
imageBDir = sys.argv[2]
path = sys.argv[3]

nameImageA = os.path.basename(imageA)
nameImageA = path + "\\algorithms\\cpickleFiles\\SSIM\\" + os.path.splitext(nameImageA)[0] + ".cpickle"
ImageA_reader = open(nameImageA, 'rb') 
ImageA = pickle.load(ImageA_reader)

conn = createDb(path + "\\algorithms\\database\\Database.db")
c = conn.cursor()

for imagePath in list_images(imageBDir):

    nameImageB = os.path.basename(imagePath)
    nameImageB = path + "\\algorithms\\cpickleFiles\\SSIM\\" + os.path.splitext(nameImageB)[0] + ".cpickle"  #IMG_005.jpg -> IMG_005.cpickle
    ImageB_reader = open(nameImageB, 'rb') 
    ImageB = pickle.load(ImageB_reader)

    (res, diff) = structural_similarity(ImageA, ImageB, full=True)
    diff = (diff * 255).astype("uint8")

    setUpdatedData(conn, imagePath, int(res*100))

conn.close()
print("OK")