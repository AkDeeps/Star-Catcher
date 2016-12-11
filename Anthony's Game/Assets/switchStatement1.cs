using UnityEngine;
using System.Collections;

public class switchStatement1 : MonoBehaviour {


    public int stuff;
    public int stuffOtherGuySays;
    
    void Awake()
    {
        stuff = Random.Range(1, 4);
        stuffOtherGuySays = Random.Range(1, 5);
    }
	
	void Start () {
        Invoke("Things", 11);
        Invoke("OtherThings", 15);
	}
	    void Things()
    {
        switch (stuff)
        {
            case 3:
                print("Come back here!");
                    break;
            case 2:
                print("Go away you square!");
                      break;
            case 1:
                print("That's it your dead meat!");
                        break;
            default: 
                print("Stop following me");
                            break;
        }
        
    }
    void OtherThings()
    {
        switch (stuffOtherGuySays)
        {
            case 4:
                print("Why are you like this?");
                break;
            case 3:
                print("I just want to be loved!");
                break;
            case 2:
                print("You are the worst kind of person");
                break;
            case 1:
                print("Stop you heathen!");
                break;
             
        }
    }

}
