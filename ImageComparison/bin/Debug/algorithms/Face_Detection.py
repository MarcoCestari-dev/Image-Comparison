import cv2
import sys
from imutils.paths import list_images

from database.Database import createDb
from database.Database import setUpdatedDataFace

imagesPath = sys.argv[1]
exePath = sys.argv[2]

cascPath = exePath + "\\algorithms\\default_config.xml"


def FaceDetection(image):
    faceCascade = cv2.CascadeClassifier(cascPath)

    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)

    faces = faceCascade.detectMultiScale(
        gray,
        scaleFactor=1.55,
        minNeighbors=5,
        minSize=(30, 30)
    )
    return len(faces)

conn = createDb(exePath + "\\algorithms\\database\\Database.db")
c = conn.cursor()

for imagePath in list_images(imagesPath):

    res = FaceDetection(cv2.imread(imagePath))

    setUpdatedDataFace(conn, imagePath, res)
conn.close()
print("OK")

