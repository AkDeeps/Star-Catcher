using UnityEngine;
using System.Collections;

public class zPush : MonoBehaviour {
    private Rigidbody rb;
    private Vector3 zForce;
    public float i = 1;

	void Start () {
        rb = GetComponent<Rigidbody>();
        zForce.z = i;
	}
	
	
	void Update () {
        rb.AddForce(zForce);
	}
}
