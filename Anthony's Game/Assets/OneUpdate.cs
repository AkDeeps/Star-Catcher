using UnityEngine;
using System.Collections;

public class OneUpdate : MonoBehaviour {

    public float speed = 1;
    private Vector3 tempPos;

 
   public void Update()
    {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
    }
}
