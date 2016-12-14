using UnityEngine;
using System.Collections;
using System;
public class Weapon: Interface1 
{

    public string damage;
    public string massive;
    public string legendary;

    public void Name()
    {

    }

    public Weapon()
    {
        damage = "brutal";
        Debug.Log ("did brutal damage");
    }

    public Weapon(string massive)
    {
        damage = massive;
        Debug.Log("did massive damage");

    }

    public void Damage()

    {
        Debug.Log("The weapon did" + damage + "damage");
    }
}
