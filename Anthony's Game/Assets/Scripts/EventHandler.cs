using UnityEngine;
using System.Collections;
using System;

public class EventHandler : MonoBehaviour {

	
	void Start () {

        DeleGateInto.EvtReturnArgs += MyEventHandler;
        DeleGateInto.EventWithArgs += EventWIthARgsHandler;
        DeleGateInto.EventString += EventStringHandler;
        DeleGateInto.IdoDeclare += IdoDeclareHandler;

	}

    private string MyEventHandler(string s)
    {
       return "your weapons are bad and you should feel bad";
    }

    private string EventWithARgsHandler(string s)
    {
        return "The Animals i HATE most are";
    }

    private string EventStringHandler(string s)
    {
        return "I hate cats";
    }

    private void IdoDeclareHandler()
    {
        print("stupid");
    }

   
}
