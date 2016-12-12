using UnityEngine;
using System.Collections;
using System;

public class otherStatics : MonoBehaviour
{

    public static string myFunc;

    public static void AddDamage(string addDamage)
    {
        MyStatics.brutalDamage++;
    }

    internal static void AddDamage()
    {
        print("added more DAMAGE");
    }
}
