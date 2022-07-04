using Godot;
using System;

public class Item : RigidBody
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
 {
	//Transform pos = (Transform)this.GetGlobalTransform();
	 if(this.Translation.y < -10){
		this.QueueFree();
	
	}
	
  }
}
