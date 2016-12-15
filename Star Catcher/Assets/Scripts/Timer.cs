using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public float remainingTime = 300;

    public Text text;

    public AudioSource countdown;
    public AudioClip threetwoone;
    public AudioClip initiate;

    void Start()
    {
        StartCoroutine("Print");
        StartCoroutine("OtherCountdown");
        countdown = GetComponent<AudioSource>();
    }


    IEnumerator Print()
    {
        yield return new WaitForSeconds(56);
        countdown.PlayOneShot(threetwoone, 1);

    }

    IEnumerator OtherCountdown()
    {
        yield return new WaitForSeconds(58);
        countdown.PlayOneShot(initiate, 1);
    }

    void Update() {

        remainingTime -= Time.deltaTime;
        text.text = " " + Mathf.Round(remainingTime);


        if (remainingTime < 0)
        {
            SceneManager.LoadScene(1);
        }

    }

}
