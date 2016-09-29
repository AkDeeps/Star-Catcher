using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class RecycleLevelComponent : MonoBehaviour{


    private Vector3 newLocation;
    public List<Recycler> recyclableList;
    private int i=0;

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
       
       
        StaticVars.nextSectionPosition += StaticVars.distance;
        newLocation.x = StaticVars.nextSectionPosition;
        recyclableList[i].cube.position = newLocation;     
        i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
        if (recyclableList.Count > 0) ;
        recyclableList.RemoveAt(i);    
            
    }

}