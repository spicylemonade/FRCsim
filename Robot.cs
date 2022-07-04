using Godot;
using System;

public class Robot : KinematicBody
{
	DifferentialDrive _diffDrive;
	PS4Controller ps4;
	TalonSRX feeder;
	TalonSRX shooter;
	TalonSRX climber;
	
	
	
	public override void _Ready() //the same as robot init
	{

	WPI_VictorSPX _rightBack = new WPI_VictorSPX(1);
	WPI_VictorSPX _rightFront = new WPI_VictorSPX(2);
		
	MotorControllerGroup _driveRight = new MotorControllerGroup(_rightBack, _rightFront);
	// left side
	WPI_VictorSPX _leftBack = new WPI_VictorSPX(3);
	WPI_VictorSPX _leftFront = new WPI_VictorSPX(4);
		
	MotorControllerGroup _driveLeft = new MotorControllerGroup(_leftBack, _leftFront);
	
	feeder = new TalonSRX(2, this);// for clarity, 3 is the object in which a motor effects
	shooter = new TalonSRX(3, this);
	climber = new TalonSRX(4, this);
	//check scene tree
	
	ps4 = new PS4Controller();
		_diffDrive = new DifferentialDrive(_driveLeft, _driveRight, this); //ignore "this"
	}

  public override void _Process(float delta) //the same as telepereodic
  {
	feeder.Set(0.0f); // set default motor speed
	shooter.Set(0.0f);
	if(ps4.getL2Button()){
		feeder.Set(1.0f);
	}
	if(ps4.getR2Button()){
		shooter.Set(1.0f);
		
	}	
	climber.Set(0.0f); 
	if(ps4.getL1Button()){
		climber.Set(4.0f);
	}
	if(ps4.getR1Button()){
		climber.Set(-4.0f);
	}		
	//_diffDrive.tankDrive(ps4.getLeftY(),ps4.getRightY());
	_diffDrive.arcadeDrive(ps4.getLeftY(),ps4.getRightX());

  }
}
