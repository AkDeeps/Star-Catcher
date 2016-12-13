using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {


    public Transform goal;
    public float time = 5;
    private Animator anim;


	void Start () {
        StartCoroutine(Spawner());
        anim = GetComponent<Animator>();
}
	
	IEnumerator Spawner()
    {
        yield return new WaitForSeconds(time);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }
    
   
}
