
using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class CoinPickup : MonoBehaviour {
	
	public int pointsToAdd;
    private int count = 0;
    public Text countText;
	

    void Start()
    {
        SetCountText();
    }

	void OnTriggerEnter (Collider cother)
	{

        count = count + 1;
        SetCountText();
        print(count);


	}
	

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}