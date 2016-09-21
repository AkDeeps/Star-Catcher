using UnityEngine;
using System.Collections;

public class Switches : MonoBehaviour {

    public int Apples = 5;
    public int oranges = 2;
    public int mangos = 3;

	void Update () {

        Apples = Random.Range(1, 22);

        switch (Apples)
        {
            case 1:
                print("theres an apple");
                break;

            case 2:
                print("there are two apples");
                break;

            case 3 - 22:
                print("there are more than two apples");
                break;

            

        }

	}
}
