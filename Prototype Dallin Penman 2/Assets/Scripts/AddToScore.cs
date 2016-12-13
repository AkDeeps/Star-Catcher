using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AddToScore : MonoBehaviour {

    public int pointsToAdd;
    private float count = Statics.score;
    public Text countText;
    public AudioSource starCollected;
    public AudioClip bing;

    public float loud = .5f;
    public float soft = .20f;

    void Start()
    {
        Statics.score = 0;


        starCollected = GetComponent<AudioSource>();
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "star") 
        {
            float volume = loud;
            starCollected.PlayOneShot(bing , volume);
            print("should have sound");
        
            Statics.count = Statics.count + 1;
            SetCountText();
            
        }


    }


 


    void SetCountText()
    {
        countText.text = "Score:  " + Statics.count.ToString();
    }


    void Update()
    {
        Statics.score = Statics.count;
    }
}
