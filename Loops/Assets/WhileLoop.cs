using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

	public int bullets = 12;

	// Use this for initialization
	void Start () {

		while (bullets > 0) {
			print (bullets);
			bullets--;
		}

		if (bullets == 0) {
			print ("No More Ammo");
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
