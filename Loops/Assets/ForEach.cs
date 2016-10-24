using UnityEngine;
using System.Collections;

public class ForEach : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		string[] weapons = new string[5];
		weapons [0] = "sword";
		weapons [1] = "axe";
		weapons [2] = "hammer";
		weapons [3] = "bow";
		weapons [4] = "spear";

		print ("Your weapons choices are:");

		foreach(string thing in weapons)
		{
			print(thing);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
