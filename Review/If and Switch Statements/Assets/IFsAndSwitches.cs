using UnityEngine;
using System.Collections;

public class IFsAndSwitches : MonoBehaviour {
    public int yourMoney = 100;

	// Use this for initialization
	void Start () {

        print("Press the spacebar to Deposit $10. Interest is at 0.01%");
        
	
	}
	
	// Update is called once per frame
	void Update () {
        //workaround to use .01% interest rate
        yourMoney = yourMoney + yourMoney /100;

        if(Input.GetKeyDown("space"))
        {
            yourMoney = yourMoney + 10;
            print("You Deposited $10. You now have $" + yourMoney);

        }

        //switches only work with ints
        switch(yourMoney)
        {
            case 150:
                print("You're off to a good start. You now have $150.");
                break;

            case 300:
                print("Your initial deposit has now tripled.");
                break;

            case 10000:
                print("It's time to take a vacation.");
                break;

            case 70000:
                print("Go buy a house.");
                break;

            case 100000:
                print("You could retire comfortably");
                break;

            case 1000000:
                print("You are now a millionaire.");
                break;

            default:
                break;
               
        }
	
	}
}
