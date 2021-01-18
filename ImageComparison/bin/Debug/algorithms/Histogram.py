# import the necessary packages
from imutils.paths import list_images 
import cv2

import pickle
import os
import sys

from database.Database import createDb
from database.Database import setUpdatedData


#-----------MAIN-----------
imageA = sys.argv[1]
imageBDir = sys.argv[2]
path = sys.argv[3]

nameImageA = os.path.basename(imageA)
nameImageA = path + "\\algorithms\\cpickleFiles\\Histograms\\" + os.path.splitext(nameImageA)[0] + ".cpickle"
histOfA_reader = open(nameImageA, 'rb') 
histOfA = pickle.load(histOfA_reader)

conn = createDb(path + "\\algorithms\\database\\Database.db")
c = conn.cursor()

for imagePath in list_images(imageBDir):

    nameImageB = os.path.basename(imagePath)
    nameImageB = path + "\\algorithms\\cpickleFiles\\Histograms\\" + os.path.splitext(nameImageB)[0] + ".cpickle"  #IMG_005.jpg -> IMG_005.cpickle
    
    histOfB_reader = open(nameImageB, 'rb') 
    histOfB = pickle.load(histOfB_reader)

    res = cv2.compareHist(histOfA, histOfB, cv2.HISTCMP_CORREL)

    setUpdatedData(conn, imagePath, int(res*100))

conn.close()
print("OK")


