using Godot;
using System;

public class MotorControllerGroup
{

	public bool side= false;
	
	public MotorControllerGroup(WPI_VictorSPX front, WPI_VictorSPX back){
		if(front.channel == back.channel){
			GD.Print("error: motors of the same channel");
		}
		else{
			this.side = true;
			}
	}

}
