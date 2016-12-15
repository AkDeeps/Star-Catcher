using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{

    int differentTypesOfWeapons = 3;
    int youHaveNoWeapon = 0;


    void Start()
    {
        while (differentTypesOfWeapons > 1)
        {
            print("You have a weapon");
            differentTypesOfWeapons--;
        }

        while (youHaveNoWeapon < 2)
        {
            print("You have no weapon");
            youHaveNoWeapon++;
        }

        for(int myInt = 1; myInt < youHaveNoWeapon; myInt++)
        {
            print("adding weapons");
        }

        for(int myOtherInt = 1; myOtherInt > youHaveNoWeapon; myOtherInt--)
        {
            print("taking away weapon");
        }

        string[] myString = new string[3];

        myString[0] = "Hammer";
        myString[1] = "spear";
        myString[2] = "Axe";

        foreach(string item in myString)
        {
            print(item);
        }

        string[] myOtherString = new string[2];
        myOtherString[0] = "Enemy wants you dead more now";
        myOtherString[1] = "You better run kid";

        foreach(string item in myOtherString)
        {
            print(item);
        }
    }
}
