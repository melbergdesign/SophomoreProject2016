using UnityEngine;
using System.Collections;
//gives access to lists, preferred over arrays
using System.Collections.Generic;
using System;

public class RecycleLevelObject : MonoBehaviour {

    private Vector3 newLocation;
    public List<Recylcer> recyclableList;
    private int i = 0;

    //subscribe to the list's action
    void Start()
    {
        //creates a new object in memory
        recyclableList = new List<Recylcer>();
        Recylcer.RecycleAction += RecycleActionHandler;


        //StaticVars.nextSectionPosition = 12;
    }

    private void RecycleActionHandler(Recylcer _r)
    {
        //adds each cube to list of items that can be recycled
        recyclableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        newLocation.x = StaticVars.nextSectionPosition;
        recyclableList[i].cube.position = newLocation;
        StaticVars.nextSectionPosition += StaticVars.distance;

        if (i < recyclableList.Count-1)
        {
            i++;
        }

    }
}
