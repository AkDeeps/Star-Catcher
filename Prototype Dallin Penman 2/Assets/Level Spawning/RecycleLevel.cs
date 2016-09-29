using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RecycleLevel : MonoBehaviour {
    
    public List<SendToRecycler> recycleList; 
    public Vector3 movePos;


	void SendThisHandler (SendToRecycler _r) 
    {
        recycleList.Add(_r);
        
    }


	void Start () {

        recycleList = new List<SendToRecycler>();
        SendToRecycler.SendThis += SendThisHandler;

	}
    int i;
    void OnTriggerEnter()
    {
        i = Random.Range(0, recycleList.Count - 1);
        movePos.x = Statics.nextPosition;
        recycleList[i].transform.position = movePos; 
        recycleList.RemoveAt (i);
        Statics.nextPosition += Statics.distance;
    }
}
