using UnityEngine;
using System.Collections;

public class GuessTheNumber : MonoBehaviour {

    private int myNumber = 8;
    public int yourNumber = 1;

	// Use this for initialization
	void Start () {

        //Prompts user with instructions
        print("I'm thinking of a number between 1 and 10. Please input your guess.");
    
        //Checks to see if number matches the answer
        if(yourNumber == myNumber)
        {
            print("That's Correct. You WIN!");
        }

        
        //Tells user to try again if number is too high or too low.

        if( yourNumber > 10 || yourNumber < 1)
        {
            print("Don't be smart. I said between 1 and 10.");
        }

        //Tells user to try again if number is incorrect.
        if (yourNumber != myNumber)
        {
            print("That's not right. Try Again.");
        }

    }

    
}
