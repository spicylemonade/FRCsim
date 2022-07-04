using Godot;
using System;

public class TalonSRX 
{
	public Node motorEffect;
	public KinematicBody robot;
	public TalonSRX(int channel, Node node){
		robot = (KinematicBody)node;
		motorEffect = (Node)node.GetChild(channel);
	}
	
	public void Set(float speed){
		motorEffect.Call("move_object", speed, robot); //calls function from another script
		
	}

  
}
