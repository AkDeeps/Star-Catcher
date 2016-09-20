using UnityEngine;
using System.Collections;

public class FunctionsMethods : MonoBehaviour {

    public int Apples = 5;
    public int oranges = 2;
    public int mangos = 3;

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown("space"))
            CheckFruit();
    }

    void CheckFruit()
    {
        //Functions was something that took me longer than I care to admit it took me to understand. I didnt realize that Update and Start were functions
        //I skated by in 1600 with alot of luck and trial and error, you explain things in a way that I am able to understand.
        //I just made this simple function from my variables script and added the getkeydown update so I can call it whenever I want

        Debug.Log(Apples++);
        Debug.Log(oranges * 2);
        Debug.Log(mangos * 0);
    }

}