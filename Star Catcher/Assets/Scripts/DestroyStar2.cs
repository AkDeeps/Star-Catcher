using UnityEngine;
using System.Collections;

public class DestroyStar2 : MonoBehaviour {



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            Destroy(this.gameObject);
        }



    }

}
