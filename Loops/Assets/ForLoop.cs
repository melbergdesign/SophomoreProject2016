using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour {

	public int foodItems = 5;

	// Use this for initialization
	void Start () {
	
		for (int i=0; i < foodItems; i++) {
			print ("You ate a thing.");
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
