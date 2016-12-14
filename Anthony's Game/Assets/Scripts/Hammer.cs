using UnityEngine;
using System.Collections;
using System;

public class Hammer : Weapon
{

    public Hammer()
    {
        damage = "brutal";
    }
	
    public Hammer(string Massive) : base(Massive)
    {
        Debug.Log("Massive damage dealt");
    }

    

}
