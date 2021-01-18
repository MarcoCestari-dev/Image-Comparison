# import the necessary packages
from imutils.paths import list_images
import pickle
import cv2
import os
import sys


def describe(image):
    kp, desc = sift.detectAndCompute(image,None)

    return kp, desc

ImagePath = sys.argv[1]
exePath = sys.argv[2]

sift=cv2.SIFT_create(6000)

image = cv2.imread(ImagePath)
image = cv2.cvtColor(image,cv2.COLOR_BGR2GRAY)
base = os.path.basename(ImagePath)

kp, desc = describe(image)

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

