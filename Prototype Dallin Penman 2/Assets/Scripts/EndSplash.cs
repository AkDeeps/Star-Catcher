using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class EndSplash : MonoBehaviour
{


    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }
}
