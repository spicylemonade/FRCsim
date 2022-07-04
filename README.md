# FRCsim
frc 2022 simulation, with editable code and objects. 

Made with Godot (mono version required with .Net sdk aswell), all scripts are written in c# for similarity with java

### Goals:

* to create a modular environment to teach and test FRC robotics code. while keeping it similar to how the Actuall robot code would look like.

* allow any team to modify robot to accomadate their design

* allow for new drivers to practice (drive train is universal)

The names for each class and method are the same as the ones in the wpilib library (although work different on the inside)

Input can be any generic gamepad controller

#### to run( without changing code):

download the build for your corresponding os

#### to run (via editor):
1. create a new folder 
2. go inside the folder and paste these files
3. open up godot and look for import, traverse your way into the folder you created and click on the "project.godot" file
4. open up the project and click the play button on the top right(or tap f5)

The main script Will be inside "Robot.cs"

#### for programmers:
wpilib library clones are located in the "lib" directory, you can expand it and implement your own classes and methods if needed.
note- in godot each file counts as a class and are imported automatically

The talonsrx class is a generic motor class for adding a motor controlled object, it calls a function on an object that must contain
a function called "move_object" which can do whatever you require it to do

add them in the "customScripts" Directory

ex. in robot a new object of talonsrx is crated called feeder, at channel 2 (channel 2 is the 2nd object under the robot scene)

![image](https://user-images.githubusercontent.com/84095175/177078370-5212f2ec-3ccc-44e3-8bdd-2b90aee7601e.png)

when called "feeder.set({speed})" then it calls the move_object function local to feeder which does its task, being deleting the ball, while shooters task is spitting it out

climbers task is moving up and down etc..

for extra help look in comments through the code or The editor Descriptions in Godot

Knowledge of the godot editor may be needed to modify the custom scripts and libraries

refer to->

https://youtu.be/y0QAvyv9Wbw

https://docs.godotengine.org/en/stable/getting_started/step_by_step/signals.html

https://docs.godotengine.org/en/stable/classes/class_kinematicbody.html#class-kinematicbody

https://haxegodot.github.io/godot/

https://haxegodot.github.io/godot/godot/JoystickList.html#Button0

and more :)

chesapeak team 8197-Airtigers

