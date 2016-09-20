using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

    public int Apples = 5;
    public int oranges = 2;
    public int mangos = 3;

    // Use this for initialization
    void Start() {
        // Variables are one of the things I understand the best, public simply makes the variable accessible in unity,
        // while a private can only be changed in the script. Using float instead of int gives you the freedom to use a decimal instead of 
        // a whole number, such as 7.5 when you need something between 7 and 8.
        
        Debug.Log(Apples++);
        Debug.Log(oranges *2);
        Debug.Log(mangos * 0);
    }


}