using UnityEngine;
using System.Collections;
using System;

public class DeleGateInto : MonoBehaviour {

    public static Action MyEvent;
    public static Action<string> EventWithArgs;

    
    public static Func<string> EventString;
    public delegate string DelReturnArgs(string s);
    public static DelReturnArgs EvtReturnArgs;

	void Start () {


        string data = EvtReturnArgs("cats") 


        EventWithArgs("Hello World");



        if(MyEvent != null)
        MyEvent();
	}
	

}
