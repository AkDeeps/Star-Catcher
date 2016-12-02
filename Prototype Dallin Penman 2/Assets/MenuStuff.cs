using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuStuff : MonoBehaviour {

    public Canvas quit;
    public Button start;
    public Button exit;



	// Use this for initialization
	void Start () {

        quit = quit.GetComponent<Canvas>();
        start = start.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
        quit.enabled = false;

	}
	
    public void Exit()
    {
        quit.enabled = true;
        start.enabled = false;
        exit.enabled = false;
    }
	
    public void Normal()
    {
        quit.enabled = false;
        start.enabled = true;
        exit.enabled = true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Random.Range(1, 3));
    }

    public void LeaveGame()
    {
        Application.Quit();
    }

}
