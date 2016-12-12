using UnityEngine;
using System.Collections;

public class Arsenal : MonoBehaviour

{


    void Start()
    {
        Debug.Log("choosing a weapon");
        Weapon myWeapon = new Weapon();
        otherStatics.AddDamage();

        Debug.Log("choosing axe" + " " + MyStatics.massiveDamage);
        Weapon myWeapon1 = new Axe();


        Debug.Log("choosing hammer" + " " + MyStatics.legendaryDamage);
        Weapon myWeapon2 = new Hammer();


        Debug.Log("choosing Spear"+  " " + MyStatics.brutalDamage);
        Weapon myWeapon3 = new Spear();

        myWeapon.Damage();
        myWeapon1.Damage();
        myWeapon2.Damage();
        myWeapon3.Damage();

    }



}
