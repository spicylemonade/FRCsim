# FRCsim

#### Chesapeak team 8197-AirTigers

https://user-images.githubusercontent.com/84095175/177384616-466215d0-5dc4-4fcc-8b68-89d014027fac.mp4


Made with Godot (mono version required with .Net SDK as well), all scripts are written in C# for similarity with Java.

### Goals:

* To create a modular environment to teach and test FRC robotics code. at the same time, we are keeping it similar to how the actual robot code would look like.

* Allow any team to modify robot to accommodate their design

* Allow for new drivers to practice (drive train is universal)

Input can be any generic gamepad controller.

The names for each class and method are the same as the ones in the WPI_lib library (although they work differently on the inside).

#### to run( without changing code):

Download the build for your corresponding os.

#### to run (via editor):
1. Create a new folder 
2. Go inside the folder and paste these files
3. Open up godot and look for import, traverse your way into the folder you created and click on the "project.godot" file
4. Open up the project and click the play button on the top right(or tap f5)

The main script will be inside "Robot.cs".

#### for programmers:
WPI_lib library clones are located in the "lib" directory, you can expand it and implement your classes and methods if needed. 

Note- in Godot each file counts as a class and is imported automatically.

The Talonsrx class is a generic motor class for adding a motor-controlled object, it calls a function on an object that must contain a function called "move_object" which can do whatever you require it to do,add them in the "custom scripts" directory.

Ex. in "robot" a new object of Talonsrx is created called feeder, at channel 2 (channel 2 is the 2nd object under the robot scene).

![image](https://user-images.githubusercontent.com/84095175/177078370-5212f2ec-3ccc-44e3-8bdd-2b90aee7601e.png)

When called "feeder.set({speed})" then it calls the move_object function local to "feeder" which does its task, being deleting the ball, while the "shooters" task is spitting it out and the "climber's" task is moving up and down etc...

For extra help look in comments through the code or The editor Descriptions in Godot.

Knowledge of the Godot editor may be needed to modify the custom scripts and libraries.

Refer to->

https://youtu.be/y0QAvyv9Wbw

https://docs.godotengine.org/en/stable/getting_started/step_by_step/signals.html

https://docs.godotengine.org/en/stable/classes/class_kinematicbody.html#class-kinematicbody

https://haxegodot.github.io/godot/

https://haxegodot.github.io/godot/godot/JoystickList.html#Button0

and more :)
