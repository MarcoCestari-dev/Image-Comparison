# import the necessary packages
from imutils.paths import list_images
import pickle
import cv2
import os
import sys


def describe(image):
	# compute a 3D histogram in the RGB colorspace,
	# then normalize the histogram so that images
	# with the same content, but either scaled larger
	# or smaller will have (roughly) the same histogram
    ranges = None
    

    imageRgb = cv2.cvtColor(image,cv2.COLOR_BGR2HSV)
    hist = cv2.calcHist(imageRgb, [0,1], None, [180,256], [0,180,0,256])
    cv2.normalize(hist, hist, alpha=0, beta=1, norm_type=cv2.NORM_MINMAX)
    
    return hist

#use list_images to grab the image paths and loop over them

ImagePath = sys.argv[1]
exePath = sys.argv[2]

dim = (1000, 1000)


image = cv2.imread(ImagePath)
image = cv2.resize(image, dim, interpolation = cv2.INTER_AREA) 
base = os.path.basename(ImagePath)

features = describe(image)
filename = exePath + "\\algorithms\\cpickleFiles\\Histograms\\" + os.path.splitext(base)[0] + ".cpickle"
file_pi = open(filename, 'wb') 
pickle.dump(features, file_pi)
file_pi.close()

print("OK, Completato")

