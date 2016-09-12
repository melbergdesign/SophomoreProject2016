using UnityEngine;
using System.Collections;
using System;

public class PowerUpBase : MonoBehaviour {

    public string firstName;
    public string lastName;

    private string userName;

    void OnMouseUp()
    {
        print( UserInfo() );
        print("Your ID is " + userName);
    }

    string UserInfo ()
    {
        userName = firstName + lastName +69;
        return firstName + " " + lastName + " are you ready to play?";
    }
}
