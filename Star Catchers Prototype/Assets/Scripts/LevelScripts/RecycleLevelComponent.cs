using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevelComponent : MonoBehaviour{


    private Vector3 newLocation;
    public List<Recycler> recyclableList;
    private int i;

    void Start()
    {
        recyclableList = new List<Recycler>();
        Recycler.RecycleAction += RecycleActionHandler;
    }

    private void RecycleActionHandler(Recycler _r)
    {
        recyclableList.Add(_r);
    }

    void OnTriggerEnter()
    {
        //i = Random.range(0, recyclableList);
        StaticVars.nextSectionPosition += StaticVars.distance;
        newLocation.x = StaticVars.nextSectionPosition;
        recyclableList[i].cube.position = newLocation;
        if (i < recyclableList.Count-1)
            i++;
    }

}