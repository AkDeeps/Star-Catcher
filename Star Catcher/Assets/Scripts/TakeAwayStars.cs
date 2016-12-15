using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TakeAwayStars : MonoBehaviour {

    public int pointsToAdd;
    private float count = Statics.score;
    public Text countText;


    void Start()
    {
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "Player")
        {
            Statics.count = Statics.count - 3;
            SetCountText();
            print(count);

        }


    }





    void SetCountText()
    {
        if (Statics.count < 0)
            Statics.count = 0;
        countText.text = "Score:  " + Statics.count.ToString();
    }

    void Update()
    {
        Statics.score = Statics.count;
    }
}
