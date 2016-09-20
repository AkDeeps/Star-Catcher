using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {

    //this is the character controller component
    public CharacterController myCC;
    //temp var of data type vector 3 to movce the character
    private Vector3 tempPos;
    //speed of the temp var in x
    public float speed = 1;
    //This is the speed
    public float gravity = -1;
    //This is the gravity 
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;

	// Use this for initialization
	void Start () {
        //this "finds" the character controller component
        myCC = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //waiting for input and comparing jump count 
        if (Input.GetKeyDown(KeyCode.Space)&& jumpCount < jumpCountMax-1) 
        {
            //incrementing the jumpcount by 1
            jumpCount++;
            //adding the jumpSpeed var to the tempPos var
            tempPos.y = jumpSpeed;
        }
       //test if the character controller is grounded 

        if (myCC.isGrounded)
        {
            //reset the jumpcount if grounded
            jumpCount = 0;
        }
        //adding the gravity var to the y position of the tempPos var

        tempPos.y -= gravity;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
        }
       //addind the speed car to the temppos var x value with the right and left arrow keys
        tempPos.x = speed* Input.GetAxis("Horizontal");
        //moves the charactercontroller at an even pace (deltaTime)
        myCC.Move(tempPos * Time.deltaTime);
        //use delta time for fixed refresh instead of 
	}
}
