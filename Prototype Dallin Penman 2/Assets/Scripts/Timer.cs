using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float remainingTime = 300;

    public Text text;


	
	void Update () {

        remainingTime -= Time.deltaTime;
        text.text = " " + Mathf.Round(remainingTime);



        if (remainingTime < 0)
        {
            SceneManager.LoadScene(1);
        }

	}
}
