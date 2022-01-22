import time
import math
import os
uom = "null"
baseinput = "null"

def get_base_input():
    print("What type of base information are you going to input?")
    print("Radius - r")
    print("Diameter - d")
    print("Circumfrence - c")
    print("Area - a")
    
print("What is the unit of measurement? (e.g. in, cm, mm, etc)")
uom = input("> ")
get_base_input()
baseinput = input("> ")

while baseinput!="r" or baseinput!="d" or baseinput!="c" or baseinput!="a" :   
    if baseinput == "r":
        print("What is the radius of the circle? Do not include the unit of measurement.")
        radius = float(input("> "))
        inp = "rad"
        break
    elif baseinput == "d":
        print("What is the diameter of the circle? Do not include the unit of measurement.")
        diameter = input("> ")
        inp = "dia"
        break
    elif baseinput == "c":
        print("What is the circumference of the circle? Do not include the unit of measurement.")
        circumf = input("> ")
        inp = "cir"
        break
    elif baseinput == "a":
        print("What is the area of the circle? Do not include the unit of measurement or the exponent.")
        area = input("> ")
        inp = "area"
        break
    else:
        print("That isn't a valid option. Please try again.")
        get_base_input()
        baseinput = input("> ")
        
if inp == "rad":
    diameter = float(radius)*2.0
    circumf = round(float(diameter)*3.14159, 2)
    area = round(float(radius)**2*3.14159, 2)
    print("The dimensions of this circle are:")
    print("Radius: " + str(radius) + " " + uom)
    print("Diameter: " + str(diameter) + " " + uom)
    print("Circumference: " + str(circumf) + " " + uom)
    print("Area: " + str(area) + " " + uom + "²")
elif inp == "dia":
    radius = float(diameter)/2.0
    circumf = round(float(diameter)*3.14159, 2)
    area = round(float(radius)**2*3.14159, 2)
    print("The dimensions of this circle are:")
    print("Radius: " + str(radius) + " " + uom)
    print("Diameter: " + str(diameter) + " " + uom)
    print("Circumference: " + str(circumf) + " " + uom)
    print("Area: " + str(area) + " " + uom + "²")
elif inp == "cir":
    diameter = round(float(circumf)/3.14159, 2)
    radius = float(diameter)/2.0
    area = round(float(radius)**2*3.14159, 2)
    print("The dimensions of this circle are:")
    print("Radius: " + str(radius) + " " + uom)
    print("Diameter: " + str(diameter) + " " + uom)
    print("Circumference: " + str(circumf) + " " + uom)
    print("Area: " + str(area) + " " + uom + "²")
elif inp == "area":
    diameter = round(2*sqrt((float(area)/3.14159)), 2)
    radius = float(diameter)/2.0
    circuf = round(float(radius)**2*3.14159, 2)
    print("The dimensions of this circle are:")
    print("Radius: " + str(radius) + " " + uom)
    print("Diameter: " + str(diameter) + " " + uom)
    print("Circumference: " + str(circumf) + " " + uom)
    print("Area: " + str(area) + " " + uom + "²")
pause_del = input("Press enter to exit this program.")