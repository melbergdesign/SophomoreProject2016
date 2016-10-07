using UnityEngine;
using System.Collections;

public class MyScript : MonoBehaviour {

    //declare the variable
    public string hello = "hello world";
    public string bye = "goodbye";

	// Use this for initialization
    // a function is a sequence of commands, performed in order
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
        //use the variable inside 'print' which is a part of system.collections
        //GetKeyDown is a function
        if (Input.GetKeyDown(KeyCode.H))
        {
            print(hello);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            print(bye);
        }
        
    }

}
