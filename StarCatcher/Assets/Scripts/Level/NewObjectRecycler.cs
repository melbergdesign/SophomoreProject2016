using UnityEngine;
using System.Collections;
//gives access to lists, preferred over arrays
using System.Collections.Generic;
using System;

public class NewObjectRecycler : MonoBehaviour
{

    private Vector3 newLocation;
    public List<NewRecycler> recyclableList;
    private int i = 0;

    //subscribe to the list's action
    void Start()
    {
        //creates a new object in memory
        recyclableList = new List<NewRecycler>();
        NewRecycler.RecycleAction += RecycleActionHandler;


        //StaticVars.nextSectionPosition = 12;
    }

    private void RecycleActionHandler(NewRecycler _r)
    {
        //adds each cube to list of items that can be recycled
        recyclableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        i = UnityEngine.Random.Range(0, recyclableList.Count - 1);

        newLocation.x = LevelStaticVars.nextSectionPosition;
        recyclableList[i].cube.position = newLocation;
        LevelStaticVars.nextSectionPosition += LevelStaticVars.distance;
        //removes just selected cube from list
        if (recyclableList.Count > 0)
        {
            recyclableList.RemoveAt(i);
        }




    }
}
