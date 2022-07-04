using Godot;
using System;

public class PS4Controller
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	//refer to https://haxegodot.github.io/godot/godot/JoystickList.html#Button0
	//https://haxegodot.github.io/godot/godot/Input.html

	public float getLeftY(){
		return Input.GetJoyAxis(0,1); // 0 is port, 1 is axis
	}
	public float getRightX(){
		return Input.GetJoyAxis(0,2);
	}
	public float getRightY(){
		return Input.GetJoyAxis(0,3);
	}
	public bool getL2Button(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.L2);
	}
	public bool getR2Button(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.R2);
	}
	public bool getCrossButton(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.Button0);
	}
	public bool getCircleButton(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.Button1);
	}
	public bool getSquareButton(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.Button2);
	}
	public bool getTriangleButton(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.Button3);
	}
	public bool getL1Button(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.L);
	}
	public bool getR1Button(){
		return Input.IsJoyButtonPressed(0,(int)JoystickList.R);
	}
	//add more actions if needed


}
