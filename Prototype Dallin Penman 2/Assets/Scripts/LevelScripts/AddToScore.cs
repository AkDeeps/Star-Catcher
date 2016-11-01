using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AddToScore : MonoBehaviour {

    public int pointsToAdd;
    private int count = 0;
    public Text countText;
   

    void Start()
    {
        SetCountText();
    }

    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "star") 
        {
            count = count + 1;
            SetCountText();
            print(count);

        }


    }


 


    void SetCountText()
    {
        countText.text = "Score:  " + count.ToString();
    }
}
