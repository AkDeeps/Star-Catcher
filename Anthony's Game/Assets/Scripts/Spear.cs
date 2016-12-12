using UnityEngine;
using System.Collections;

public class Spear : Weapon
{

	public Spear()
    {
        damage = "brutal";
    }

    public Spear(string Massive): base(Massive)
    {
        Debug.Log("Spear did massive damage");
    }



}
