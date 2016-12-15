using UnityEngine;
using System.Collections;

public class AddStarForce : MonoBehaviour {

   public  Vector3 star;
   public Rigidbody Cube;
    public Vector3 torque;
	// Use this for initialization
	void Start () {
        Cube = GetComponent<Rigidbody>();
	}
	
    void OnTriggerEnter()
    {
        star.x = Random.Range(-500,500);
        Cube.AddForce(star);
        Cube.AddTorque(star);
    }

}
