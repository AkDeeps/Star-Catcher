using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {


    public CharacterController myCC;
    private Vector3 tempPos;
    public float speed = 1;
    public float gravity = -1;
    public float jumpSpeed = 1;
    public int jumpCount = 0;
    public int jumpCountMax = 2;

    private Animator animator;
    int jumpHash = Animator.StringToHash("land");
    int landHash = Animator.StringToHash("jump");



    void Start() {

        myCC = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    void Update() {

        HandleLayers();

        if (myCC.velocity.y < -2)
        {
            animator.SetBool(landHash, true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            animator.SetTrigger(jumpHash);

            if (myCC.isGrounded)
            {
                tempPos.y = jumpSpeed;
                jumpCount = 0;
                animator.ResetTrigger(jumpHash);
                animator.SetBool(landHash, false);

            }

            if (!myCC.isGrounded && jumpCount < jumpCountMax - 1)
            {
                jumpCount++;
                tempPos.y = jumpSpeed;
            }
           
        }


        if (myCC.isGrounded)
        {

            jumpCount = 0;
       
        }


        tempPos.y -= gravity;


        tempPos.x = speed * Input.GetAxis("Horizontal");

        myCC.Move(tempPos * Time.deltaTime);
        animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
    }

    void HandleLayers()
    {
        if (myCC.isGrounded)
        {
            animator.SetLayerWeight(1, 0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetLayerWeight(1, 1);
            }


        }

        else
        {
            animator.SetLayerWeight(1, 1);
        } 
        
         
    }





}
