using UnityEngine;
using System.Collections;
using System;
public class DelegatesGeneral : MonoBehaviour {

    Action <int> Move;
    Action Jump;
    Action Idle;


    void MoveHandler(int _speed)
    {
        print("moving at "+ _speed+"mph");
        Move = null;
        Idle = IdleHandler;
    }


    void IdleHandler()
    {
        print("idling");
        Idle = null;
        Jump = JumpHandler;
    }

    void JumpHandler()
    {
        print("jumping");
        Jump = null;
        Start();
    }


	void Start () {
        Move = MoveHandler;
       
	}
	
	
	void Update () {
        if (Move != null)
            Move(50);
        if (Idle != null)
            Idle();
        if (Jump != null)
            Jump();

	}
}
