using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour {

    int health = 250;


    //Actions are a type of delegate. Delegates contain functions just as vars contain data
    Action DisplayHealth;
    Action KillThePLayer;
    Action EndTHeGame;
	
    

	void Start () {
        //We assign the function DisplayHealthHandler to the action DisplayHealth;
        DisplayHealth = DisplayHealthHandler;

	}

    void EndTheGameHandler()
    {
        print("you died. you didnt even try loser");
        EndTHeGame = null;
    }

    void KillThePlayerHandler()
    {
        print(health);
        health--;
        if (health < 0)
        {
            KillThePLayer = null;
            EndTHeGame = EndTheGameHandler;
        }
    
    }
  



    void DisplayHealthHandler()
    {
        print("Health is good");
        //We unassign all function from DisplayHealth
        DisplayHealth = null;
        KillThePLayer = KillThePlayerHandler;

        
    }

	void Update () {
        //We check if any function is assigned to DisplayHealth
        //If nothing is assigned DisplayHealth will not run
        if (DisplayHealth != null)
            DisplayHealth();
        if (KillThePLayer != null)
            KillThePLayer();
        if (EndTHeGame != null)
            EndTHeGame();

	}
}
