using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Lists : MonoBehaviour {

 void Start()
    {
        Dictionary<string,int> specialWeapons =
            new Dictionary<string,int>();

        specialWeapons.Add("Battle Axe", 1);
        specialWeapons.Add("Battle Hammer", 1);
        specialWeapons.Add("Battle Spear",1);




        Dictionary<string, int> otherSpecialWeapons =
            new Dictionary<string, int>();

        otherSpecialWeapons.Add("Epic Axe", 1);
        otherSpecialWeapons.Add("Epic Hammer", 1);
        otherSpecialWeapons.Add("Epic Spear", 1);

     
    }
}
