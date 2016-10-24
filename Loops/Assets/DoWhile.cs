using UnityEngine;
using System.Collections;

public class DoWhile : MonoBehaviour {

	public bool houseStillStanding = false;

	// Use this for initialization
	void Start () {

		do {
			print ("Throw a grenade.");
		} while(houseStillStanding == true);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
