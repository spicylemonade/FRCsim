using Godot;
using System;

public class Feeder : Area
{
	//these "Areas" can be seen as motor parts/areas where a motor effects and moves an "otem"
	//example: the feeder is a motor belt mechnism that takes a ball in
	// It then deletes the ball item and the shooter motor area spits out the part
	// Called when the node enters the scene tree for the first time.
	KinematicBody Robot;
	RigidBody body;
	public float Speed=0;
	public override void _Ready()
	{
		
	}

	public void move_object(float speed, KinematicBody Robot = null){
		Speed = speed;
		this.Robot = Robot;
		if (speed != 0){
			if(body != null && ((Spatial)GetNode("Ball")).Visible == false){
				body.QueueFree();
				((Spatial)GetNode("Ball")).Visible = true;
				body = null;
			}
		}
		
	}
	public override void _Process(float delta){
		if(Speed != 0){
			move_object(Speed, Robot);
		}
	}
	private void _on_Area_body_entered(RigidBody body)
	{
		// Replace with function body.
		if(body.IsInGroup("Item")){
			this.body = body;
		}
	}
	private void _on_Feeder_body_exited(object body)
	{
			this.body = null;
	}

	
}
