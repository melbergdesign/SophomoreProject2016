using UnityEngine;
using System.Collections;
//Lists namespace
using System.Collections.Generic;

public class List : MonoBehaviour {

	public List<BuffItem> buffitems = new List<BuffItem> ();

	// Use this for initialization
	void Start () {
		//add items from the scene to the list
		buffitems.Add(GameObject.FindGameObjectsWithTag("Buff Item"));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
