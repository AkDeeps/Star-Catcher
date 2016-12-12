using UnityEngine;
using System.Collections;
using System;

public class DeleGateInto : MonoBehaviour {

    public static Action IdoDeclare;
    public static Action<string> EventWithArgs;
    public static Action <string> EventString;
    public static Action<string> EvtReturnArgs;
    public string myString;

    void Start () {

        myString = ("its a string yo");
     
        IdoDeclare();

        EvtReturnArgs(myString);

       

      
	}
	

}
