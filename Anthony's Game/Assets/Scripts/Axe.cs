using UnityEngine;
using System.Collections;

public class Axe : Weapon
{

    public Axe()
    {
        damage = "massive";
    }

    public Axe(string Brutal) : base(Brutal)
    {
        Debug.Log("axe did brutal damage");
    }


}
