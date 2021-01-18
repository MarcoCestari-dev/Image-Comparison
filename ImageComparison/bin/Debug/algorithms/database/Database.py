import sqlite3
from sqlite3 import Error
import sys
import pickle
import os
from imutils.paths import list_images

def setDefaultData(imageBDir, path):
    if os.path.exists(path):
        os.remove(path)

    conn = createDb(path)
    c = conn.cursor()
    for imagePath in list_images(imageBDir):

        query = "INSERT INTO Images (Name, TemporaryResultComparision, Face_detected) VALUES (?, ?, ?)"
        c.execute(query, (imagePath, 0, 0))
    conn.commit()
    conn.close()
    print("OK")

def setUpdatedData(conn, name, percent):
    c = conn.cursor()
   
    query = "UPDATE Images SET TemporaryResultComparision = ? WHERE Name = ?"
    c.execute(query, (percent, name))
    conn.commit()

def setUpdatedDataFace(conn, name, percent):
    c = conn.cursor()
   
    query = "UPDATE Images SET Face_detected = ? WHERE Name = ?"
    c.execute(query, (percent, name))
    conn.commit()

def createDb(db_file):
    conn = None
    try:
        
        if not os.path.exists(db_file):
            conn = sqlite3.connect(db_file)
            c = conn.cursor()
            c.execute('''CREATE TABLE Images ([Name] TEXT PRIMARY KEY, 
                                              [TemporaryResultComparision] INTEGER,
                                              [Face_detected] INTEGER)''')                                  
        else:
            conn = sqlite3.connect(db_file)

    except Error as e:
        print(e)

    return conn


imageBDir = sys.argv[1]
path = sys.argv[2]
setDef = sys.argv[3]


if (setDef == "True"): setDefaultData(imageBDir, path + "\\algorithms\\database\\Database.db")



#-----------MAIN-----------

    #image = "1.jpg"
    #try to save hist of 1.jpg and 2.jpg on database
    #runQuery(conn, image, 50, 0)

    # cursor = conn.execute("SELECT TemporaryResultComparision FROM Images WHERE Name='1.jpg'")
    # for row in cursor:
    #     prova = row[0]

    # print(prova)

