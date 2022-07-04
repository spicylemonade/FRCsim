using Godot;
using System;

public class Shooter : Area
{

	public PackedScene item;
	public RigidBody NewItem;
	public KinematicBody Robot;

	public float Speed=0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		item = (PackedScene)ResourceLoader.Load("res://Scenes/Item.tscn");
	
	}

	
	public void move_object(float speed, KinematicBody Robot = null){
		this.Robot = Robot;
		Speed = speed;
		if (speed != 0){
			Spatial ItemVisible = (Spatial)GetNode("../Feeder/Ball");
			if(ItemVisible.Visible == true){
				ItemVisible.Visible = false;
				Transform globalPos = this.GlobalTransform;
				globalPos.origin +=  new Vector3(0, 3, 0);
				NewItem = (RigidBody)item.Instance();
				NewItem.GlobalTransform=globalPos;
				//setting the item instance position to this motorobject position

				NewItem.ApplyCentralImpulse(((KinematicBody)GetParent()).Transform.basis.z *-10+new Vector3(0,15,0));
				//my robot specific, adds force to shoot robot outwards, basis.z refers to its relative z pos
				GetTree().Root.GetNode("World/ItemGroup").AddChild(NewItem);
				//adds robot to world(in this case, item group)
				
			}
		}
	}
	public override void _Process(float delta){
		if(Speed != 0){
			move_object(Speed, Robot);
		}
	}


}
