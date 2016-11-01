using UnityEngine;
using System.Collections;

public class GetRidOfStar : MonoBehaviour {

    public int delay = 4;



    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

    //IEnumerator OnCollisionEnter(Collider other)
    //{
    //    if (other.tag == "ground")
    //    {
    //        yield return new WaitForSeconds(delay);
    //        Destroy(this.gameObject);
    //    }


    //        yield return null;




    //}
}
