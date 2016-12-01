using UnityEngine;
using System.Collections;

public class GetRidOfStar : MonoBehaviour {

    public int delay = 4;



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
       
    }

    
}
