using UnityEngine;
using System.Collections;

public class PlayerAnimationController : MonoBehaviour
{

    //Public Variables
    //[Header("Transform Variables")]
    public float RunSpeed = 0.1f;
    public float TurnSpeed = 6.0f;


    public Animator animator;
    float vertical = 0;
    public PlayerController controller;

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }


    void Start()
    {
        /**
        * Initialize the animator that is attached on the current game object i.e. on which you will attach this script.
        */
        controller = GetComponent<PlayerController>();
        //animator = GetComponent<Animator>();
    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.TryGetComponent<Interactables>(out Interactables inter))
        {
            controller.isAttaking = true;
            Invoke("CanceAttacking", 2);


           
                animator.Play("Attack");
            



            //animator.Play("Attack");
        }
       
        
    }private void CanceAttacking()
    {
        controller.isAttaking = false;

            
    }



    void Update()
    {
        
        /**
        * The Update() function will get the bool parameters from the animator state machine and set the values provided by the user.
        * Here, I have only added animation for Run and Idle. When the Up key is pressed, Run animation is played. When we let go, Idle is played.
        */
        if (controller != null)
        {
            vertical = controller.joystick.Vertical;
        }
        if (vertical != 0)
        {
            animator.SetBool("PerformRun", true);
            animator.SetBool("PerformIdle", false);
        }
        else
        {
            animator.SetBool("PerformRun", false);
            animator.SetBool("PerformIdle", true);
        }
    }

    void OnAnimatorMove()
    {
        /**
         * OnAnimatorMove() function will shadow the "Apply Root Motion" on the animator. Your game objects psoition will now be determined 
         * using this fucntion.
         */


        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * RunSpeed);
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.up * Time.deltaTime * TurnSpeed);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(-Vector3.up * Time.deltaTime * TurnSpeed);
            }
        }*/

    }



}