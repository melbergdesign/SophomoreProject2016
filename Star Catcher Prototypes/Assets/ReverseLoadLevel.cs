﻿using UnityEngine;
using System.Collections;

public class ReverseLoadLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnTriggerEnter (){
		Application.LoadLevel ("Prototype 01");
	}
}
