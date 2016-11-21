using UnityEngine;
using System.Collections;

public class Overloading : MonoBehaviour {




    void Move (int speed)
    {
        Vector3 vector = new Vector3(speed, 0, 0);
    }

    void Move (string speed)
    {

    }


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
