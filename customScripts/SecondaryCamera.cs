using Godot;
using System;

public class SecondaryCamera : Camera
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventKey eventKey)
	   	 if (eventKey.Pressed && eventKey.Scancode == (int)KeyList.Space)
			this.Current = !this.Current;
	}


}
