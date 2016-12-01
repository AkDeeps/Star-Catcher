using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour
{

    public int forceTime = 10;
    public float forceDuration = 0.1f;
    private Rigidbody rigid;
    public float forceRange = 10;
    public float torqueRange = 2;
    private Vector3 forceVector;
    private Vector3 torqueVector;
   // private Animator anims;

    void Start()
    {
        //anims = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
        StartCoroutine(RunRandomForce());
    }

    IEnumerator RunRandomForce()
    {

        while (forceTime > 0)
        {
            yield return new WaitForSeconds(forceDuration);
            forceVector.x = 100;
            torqueVector.z = 100;
            rigid.AddTorque(torqueVector);
            rigid.AddForce(forceVector);
            forceTime--;
        }
    }

   






}