using UnityEngine;
using System.Collections;

public class SpacebarCounter : MonoBehaviour {
    //Var to count # of button presses; start at 0

    private int countPresses = 0;

	// Use this for initialization
	void Start () {
        print("Welcome to Spacebar Counter. Press the Spacebar.");
	}

    // Update is called once per frame
    void Update() {

        //runs function when button is pressed
        if (Input.GetKeyDown("space"))
        {
            //call function
            countPresses = ButtonPressed(countPresses);

            //print count #
            print("You have pressed the spacebar " + countPresses + " times.");
        }

	}

    //function increments counter
    int ButtonPressed(int currentPressNum)
    {
        currentPressNum++;

        return currentPressNum;
    }
}
