using UnityEngine;
using System.Collections;

public class OtherDelegate : MonoBehaviour
{

    void Start()
    {

        DeleGateInto.EvtReturnArgs += MyEventHandlers;
        DeleGateInto.EventWithArgs += EventWithARgsHandler;
        DeleGateInto.EventString += EventStringHandler;
        DeleGateInto.IdoDeclare += IdoDeclareHandler;

    }

  private void MyEventHandlers(string b)
    {
        print(b);
    }

    private void EventWithARgsHandler(string s)
    {
        print (s);
    }

    private void EventStringHandler(string d)
    {
        print(d);
    }

    private void IdoDeclareHandler()
    {
        print("stupid");
    }
}