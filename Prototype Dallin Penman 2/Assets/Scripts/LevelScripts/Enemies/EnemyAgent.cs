using UnityEngine;
using System.Collections;

public class EnemyAgent : MonoBehaviour {

    public NavMeshAgent myAgent;
    public Transform Player;

	void Update () {
        myAgent.destination = Player.position;
	}
}
