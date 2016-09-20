using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

    public float Apples = 5.5f;
    public float oranges = 2.3f;
    public float mangos = 3.3f;


    // Update is called once per frame
    void Start()
    {

        if (Apples < oranges)
        {
            print("There are more oranges");
        }
        if (oranges < Apples)
        {
            print("There are more apples");
        }

    }
}
