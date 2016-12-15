using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {


    public bool playOnAwake;

	
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
	}
	
}
