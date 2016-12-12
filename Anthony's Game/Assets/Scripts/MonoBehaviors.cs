using UnityEngine;
using System.Collections;

public class MonoBehaviors : MonoBehaviour {

      void Awake()
    {
        print("hi how are ya");
        otherStatics.AddDamage();
    }


    void OnTriggerEnter(Collider other)
    {
        
        Invoke("doSomething", 2);
  
       
    }

    void OnTriggerExit()
    {
        print("that was a weird feeling");
    }

    void doSomething()
    {
        print("whats happening");
    }

}   

