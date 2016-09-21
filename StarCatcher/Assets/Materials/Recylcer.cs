using UnityEngine;
using System.Collections;
//simplest library of delegates
using System;

public class Recylcer : MonoBehaviour
{

    public static Action<Recylcer> RecycleAction;
    //by default, bools are false
    //level checks if it can be recycled; if it is in the sequence, it cannot be recycled
    public bool canBeRecycled = false;
    public Transform cube;

    // Use this for initialization
    void Start()
    {
        cube = this.GetComponent<Transform>();

        if (RecycleAction != null && canBeRecycled)
        {
            RecycleAction(this);
        }
    }

    void OnTriggerEnter()
    {
        canBeRecycled = true;
        //Subscribe to action; adds itself to the list (Runs start again)
        Start();
    }

}

