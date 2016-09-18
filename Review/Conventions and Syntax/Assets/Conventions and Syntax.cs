//These are namespaces. They act as 'libraries' so you can access code that has already been conveniently prepared for you, such as CharacterController.
using UnityEngine;
using System.Collections;

//This is the class name. It needs to match the name of the script in order to work.
public class ConventionsandSyntax : MonoBehaviour {
    //This is a single line Comment

    /*This is 
     * a multi-line
     * Comment
     */

    //Comments are used to make notes to yourself and coworkers. They can also be used to "Turn Off" parts of the code to aid you in debugging.



	// Use this for initialization. Only runs once at the Start. 
    //This is a function. It starts and ends with {}. It does not use a semicolon.
	void Start () {

        //Statements are single-line pieces of code. Ends with a semicolon
        //indent code that is nested inside another block of code.
        //Statements go inside functions
        Debug.Log("This is a statement.");
        //The dot operator "." indicates that you are accessing an element of a 'Compound item' in unity. In this example, "Log" is an item found within "Debug".

	}
	
	// Update is called once per frame. Constantly updating. Put repeating functions here.
	void Update () {
	
	}
}
