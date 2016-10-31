using UnityEngine;
using System.Collections;
using System;

public class StarSpawner : MonoBehaviour {

    public static Action<Transform> SendSpawner;
    //refers to class

    // Use this for initialization
	void Start () {

        if (SendSpawner != null)
        {
            SendSpawner(transform);
            //refers to the transfrom of an object
        }



    }
	
	
}
