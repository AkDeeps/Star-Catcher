using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OtherMonoBehaviors : MonoBehaviour {

  void Awake()
    {
        print("LETS START");
    }

	void OnMouseDown()
    {
        
        SceneManager.LoadScene(1);
    }

  
    
}
