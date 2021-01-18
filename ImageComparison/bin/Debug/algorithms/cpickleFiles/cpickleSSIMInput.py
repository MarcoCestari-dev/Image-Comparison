# import the necessary packages
from imutils.paths import list_images
import pickle
import cv2
import os
import sys


def describe(image):
	# convert the images to grayscale
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

    # compute the Structural Similarity Index (SSIM) between the two
    # images, ensuring that the difference image is returned
    return gray


#use list_images to grab the image paths and loop over them

ImagePath = sys.argv[1]
exePath = sys.argv[2]

image = cv2.imread(ImagePath)
dim = (1000, 1000)
image = cv2.resize(image, dim, interpolation = cv2.INTER_AREA) 
base = os.path.basename(ImagePath)

features = describe(image)
filename = exePath + "\\algorithms\\cpickleFiles\\SSIM\\" + os.path.splitext(base)[0] + ".cpickle"
file_pi = open(filename, 'wb') 
pickle.dump(features, file_pi)
file_pi.close()


print("OK, Completato")

