using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour {

    int health = 250;

    //Actions are a type of delegate. Delegates contain functions just as vars contain data.
    Action DisplayHealth;
    Action KillThePlayer;
    Action EndTheGame;


	// Use this for initialization
	void Start () {
        //We assign the function DisplayHealthHandler to the action DisplayHealth
        DisplayHealth = DisplayHealthHandler;
	}

    void DisplayHealthHandler()
    {
        print("Health is good.");
        //We unassign all functions from action DisplayHealth
        DisplayHealth = null;
        KillThePlayer = KillThePlayerHandler;
    }
    //Naming convention to relate the function to the delegate.
    void KillThePlayerHandler()
    {
        health--;
        print(health);

        if (health < 0)
        {
            KillThePlayer = null;
            EndTheGame = EndTheGameHandler;
        }
    }
    void EndTheGameHandler()
    {
        print("Loser.");
        EndTheGame = null;
    }
	
	// Update is called once per frame
	void Update () {

        //We check if any function is assigned to DisplayHealth
        //if nothing is assigned, DisplayHealth will not run
        if (DisplayHealth != null)
        {

            DisplayHealth();
        }
        if (KillThePlayer != null){
            KillThePlayer();
        }
        if (EndTheGame != null)
        {
            EndTheGame();
        }
	}
}
