using UnityEngine;
using System.Collections;
using System;

public class DelegatesGeneral : MonoBehaviour {

	//8. Can pass and receive vars
	Action <DelegatesGeneral> Move;
	Action Idle;
	Action Jump;

	int speed = 200;

	//1. delegate is a function CONTAINER
	//4. Nothing happening until they are subscribed
	void MoveHandler(DelegatesGeneral obj){

		print ("moving at " + obj.speed + "mph");
		//6. functions run sequentially b/c we subscribe and unsubscribe each one
		Move = null;
		Idle = IdleHandler;

	
	}

	void IdleHandler(){
		print ("idling");
		Idle = null;
		Jump = JumpHandler;
	}

	void JumpHandler(){
		print ("jumping");
		Jump = null;
	
	}

	// Use this for initialization
	void Start () {
		//5. Subscribes the handlers to the delegates
		Move = MoveHandler;
		}



	// Update is called once per frame
	void Update () {
		//2. "Null reference exception" = this function has nothing to do
		//7. Create a check to see if the script should be run (Otherwise it will run forever.)
		if(Move != null) {
			Move (this);
		}
		if(Idle != null) {
			Idle ();
		}
		if (Jump != null) {
			Jump ();
		}
		//3. Subscribe = tell the script to run
	}
}
