using UnityEngine;
using System.Collections;
using System;

public class GameControl : MonoBehaviour {

	public static Action StartGame;
	public static Action EndGame;

	//delegates are containers that hold functions

	public void StartGameCall()
	{
		print ("Start");
		if (StartGame != null) {
			StartGame ();

		}
	}
}
