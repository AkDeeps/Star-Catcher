using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour
{

    public int floatTime;
    public float forceDuration = 0.1f;

    private bool canAddForce = true;
    private Rigidbody ridgid;
    private float force;
    private Vector3 forceVector;
    public float forceRange = 10;
    private Vector3 torqueVector;
    

    void Start()
    {
        ridgid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }



    IEnumerator RunRandomForce()
    {
        force = Random.Range(-forceRange, forceRange);
        print("force");

        while (forceDuration > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = force;
            torqueVector.z = force*force;
            ridgid.AddForce(forceVector);
            ridgid.AddTorque(torqueVector);
            forceDuration--;
            
        }
    }

    public float endTime = 3;

 
    void OnCollisionEnter()
    {
        //canAddForce = false;
        Destroy(gameObject, endTime);
    }
    // Use this for initialization
    //IEnumerator EndStar()
    //{
    //    yield return new WaitForSeconds(endTime);

    //}

}