using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UvuLogoAway : MonoBehaviour {



    void Start()
    {
        StartCoroutine("Wait");
    }

	IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }


}
