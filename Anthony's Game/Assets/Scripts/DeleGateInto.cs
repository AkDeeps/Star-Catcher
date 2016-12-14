using UnityEngine;
using System.Collections;
using System;

public class DeleGateInto : MonoBehaviour {

    public static Action IdoDeclare;
    public static Action<string> EventWithArgs;
    public static Action <string> EventString;
    public static Action <string>EvtReturnArgs;


    void Start () {

        EventWithArgs("something"); 

        EventString("somethingElse");

        EvtReturnArgs("somethingElseElse");
     
        IdoDeclare();

      

       

      
	}
	

}
