using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public CharacterController myCC;
    public float gravity = 1;
    public Vector3 temoPos;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        temoPos.y -= gravity * Time.deltaTime;
        myCC.Move(temoPos);
	}
}
