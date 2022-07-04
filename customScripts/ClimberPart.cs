using Godot;
using System;

public class ClimberPart : KinematicBody
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	KinematicBody Robot;
	public bool onBar = false;
	public float downSpeed = 0f;

	public float Speed=0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AxisLockMotionZ = true;
		AxisLockMotionX = true;
	}
	public void move_object(float speed, KinematicBody Robot = null){
		Speed = speed;
		this.Robot = Robot;
		this.MoveAndSlide(new Vector3(0,speed,0),Vector3.Up, false, 4,0.785398f,false);
		if(speed <0 && onBar == true){
			Robot.MoveAndSlide(new Vector3(0,speed*(-1),0),Vector3.Up, false, 4,0.785398f,false);
			//this.MoveAndSlide(new Vector3(0,.5f,0),Vector3.Up, false, 4,0.785398f,false);
		}
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	if(Speed != 0){
			move_object(Speed, Robot);
		}
	try{
	  Robot.MoveAndSlide(new Vector3(0,downSpeed,0),Vector3.Up, false, 4,0.785398f,false);
	}
	catch{}
 }
private void _on_Area_body_entered(object body)
{
	// Replace with function body.
	onBar = true;
	downSpeed = 0f;
	
}


private void _on_Area_body_exited(object body)
{
	// Replace with function body.
	onBar = false;
	//Robot.MoveAndSlide(new Vector3(0,3,0),Vector3.Up, false, 4,0.785398f,false);
	downSpeed = -5f;

}

}

