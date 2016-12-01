using UnityEngine;
using System.Collections;
using System;

public class EventHandler : MonoBehaviour {

	
	void Start () {

        DeleGateInto.EvtReturnArgs += MyEventHandler;
        DeleGateInto.EventWithArgs += EventWIthARgsHandler;
        DeleGateInto.EventString += EventStringHandler;

	}

    private string MyEventHandler(string s)
    {
        return "The Animals i HATE most are";
    }

    private string EventStringHandler()
    {
        return "I hate cats";
    }

    private void EventWIthARgsHandler(string s)
    {
        print(s);
    }

   
}
