using UnityEngine;
using System.Collections;

public class FakeParallax : MonoBehaviour {

    private Vector3 movePos;
    public float speed = 1;

    void Update()
    {
        movePos.x = speed * Time.deltaTime;
        transform.Translate(movePos);
    }
}
