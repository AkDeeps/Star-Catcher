using UnityEngine;
using System.Collections;

public class Weapon
{

    public string damage;
    public string massive;
    public string legendary;


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
