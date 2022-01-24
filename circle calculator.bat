@echo off
title Dimensions of Circle Calculator

echo What is the unit of measurement? (e.g. in, cm, mm, etc)
set /p uom="> "
echo.

:get_base_info
echo What type of base information are you going to input?
echo Radius - r
echo Diameter - d
echo Circumfrence - c
echo Area - a
set /p baseinfo="> "
echo.

if %baseinfo%==r goto get_rad
if %baseinfo%==d goto get_dia
if %baseinfo%==c goto get_cir
if %baseinfo%==a goto get_area

echo That isn't a valid option.
goto get_base_info

:get_rad
echo What is the radius of the circle? Do not include the unit of measurement.
set /p radius="> "
set inp=rad
goto calculate

:get_dia
echo What is the diameter of the circle? Do not include the unit of measurement.
set /p diameter="> "
set inp=dia
goto calculate

:get_cir
echo What is the circumfrence of the circle? Do not include the unit of measurement.
set /p circumfrence="> "
set inp=cir
goto calculate

:get_area
echo What is the area of the area? Do not include the unit of measurement or the exponent.
set /p area="> "
set inp=area
goto calculate

:calculate
goto calculate_%inp%

:calculate_rad
set /a diameter=%radius%*2
set /a circumfrence=%diameter%*3.14
set /a area_temp=%radius%*%radius%
set /a area=%area_temp%*3.14
echo %diameter% diameter
echo %circumfrence% circumfrence
echo %area% area
pause
