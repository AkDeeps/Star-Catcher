using UnityEngine;
using System.Collections;
using System;

public class Coroutines : MonoBehaviour {


	void Start () {
      
        StartCoroutine("PrintAnotherThing");
        StartCoroutine("PrintOneThing");
        StartCoroutine("PrintThirdThing");
        StartCoroutine("LastOne");
	}

  

    IEnumerator PrintOneThing()
    {
        yield return new WaitForSeconds(25);
        print("ok you waited 10 seconds for no reason");
    }

    IEnumerator PrintAnotherThing()
    {
        yield return new WaitForSeconds(20);
            print ("well, you waited 5 seconds for no reason");
    }


    IEnumerator PrintThirdThing()
    {
        yield return new WaitForSeconds(30);
        print("it's been 15 seconds, you have no life");
    }
    IEnumerator LastOne()
    {
        yield return new WaitForSeconds(35);
        print("stop please");
    }
}
