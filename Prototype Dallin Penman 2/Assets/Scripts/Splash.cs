using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour {

	
	void OnMouseDown()
    {
        SceneManager.LoadScene(Random.Range(1, 3));
    }
}
