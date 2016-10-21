using UnityEngine;
using System.Collections;
using System;

public class Recycler : MonoBehaviour {

	public static Action<Recycler> RecycleAction;
	public bool canBeRecycled = false;
	public Transform cube;

	void Start () {
        //cube refers to the Transform of the object it touches
		cube = this.GetComponent<Transform>();
		if (RecycleAction != null && canBeRecycled)
			RecycleAction(this);
	}

    //when an object touches the object this script is attached to
	void OnTriggerEnter ()
	{
        //change the value of canBeRecycled to true
		canBeRecycled = true;
		Start();
	}
}