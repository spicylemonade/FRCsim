using Godot;
using System;

public class DifferentialDrive
{
	// Declare member variables here. E

	KinematicBody Robot;
	bool Lside;
	bool Rside;
	Vector3 velocity= new Vector3(0,0,0);
	public DifferentialDrive(MotorControllerGroup Left,MotorControllerGroup Right, KinematicBody Robot){
		this.Robot = Robot;
		this.Lside = Left.side;
		this.Rside = Right.side;
	}
	


//  // Called every frame. 'delta' is the elapsed time since the previous frame.
public void collCheck(int type =0,float val1 =1, float val2=1){
	for (int i = 0; i < Robot.GetSlideCount(); i++)
		{
			KinematicCollision collision = (KinematicCollision)Robot.GetSlideCollision(i);
			try{RigidBody temp = (RigidBody)collision.Collider;
			temp.ApplyCentralImpulse(-1*(collision.Normal)*(0.5f)*(val1*val2)); //0.5 is top force
			}
			catch{}
			//-1 * collision normal is vector pointing away from robot
			
		}
}
  public void tankDrive(float lside, float rside)
  {
		//
		Robot.RotateY(0.03f*(lside+(rside* -1))); // moltuplied times -0.1 to have max rotation speed
		// negative makes robot rotate to the right and positive to left
		//up value on up joystick is negative by default for both axis,
		//so I negate right side to make opposite and if both are up (-1+(-1*-1))= 0 then no rotation
		float checker = 1.0f;
		if(lside>0 && rside > 0){
			checker = -1.0f;
		}
		//if aiming to move backward, make negative (for checker)
		//this could be worked
		velocity = Robot.Transform.basis.z *(10*((lside*rside)*checker));
		// if both joysticsk are up then robot moves foreward (-1*-1)=1* speed(10)
		//but if both are down then multiply *-1
		//this.RotationDegrees += 200;
		Robot.MoveAndSlide(velocity,Vector3.Up, false, 9,0.785398f,false);
		collCheck(0,lside,rside);
		
		//Godot exclusive to prevent infinite enertia and custome forse collisions
	 
  }
  public void arcadeDrive(float xDrive, float zRotation){
	Robot.RotateY(0.1f*(zRotation*-1));

	velocity = Robot.Transform.basis.z *(10*(xDrive*-1));

	Robot.MoveAndSlide(velocity,Vector3.Up, false, 9,0.785398f,false);

	collCheck(1,xDrive,zRotation+(0.3f*xDrive));
  }
}
