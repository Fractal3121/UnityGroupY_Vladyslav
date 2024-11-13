using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdAnimationScript : MonoBehaviour
{
    public GameObject bulletCloneTemplate;
    Rigidbody rb;
    Animator edAnimator;
    float edSpeed = 2;
    float edSpeedBack = 1;
    float edRun = 4;
    float edRunBack = 2;
    int turningSpeed = 55;

    // Start is called before the first frame update
    void Start()
    {
        edAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set up running condition for future
        edAnimator.SetBool("isRunning", false);

        //Make Wave animation

        if (Input.GetKeyDown(KeyCode.H))
        {
            edAnimator.SetBool("isWave", true);
        }
        else edAnimator.SetBool("isWave", false);

        //Make Ed walk animation and move forward

        if (Input.GetKey(KeyCode.W))
        {           
            edAnimator.SetBool("isWalking", true);
            transform.position += edSpeed * transform.forward * Time.deltaTime;
            //Rotation when walking
            if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
            //Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                edAnimator.SetBool("isRunning", true);
                transform.position += edRun * transform.forward * Time.deltaTime; 
            }
        }
        else edAnimator.SetBool("isWalking", false);

        //Backward walking animation

        if (Input.GetKey(KeyCode.S))
        {
            edAnimator.SetBool("isBackward", true);
            transform.position -= edSpeedBack * transform.forward * Time.deltaTime;
            //Rotation when walking
            if (Input.GetKey(KeyCode.E)) transform.Rotate(Vector3.up, turningSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.Q)) transform.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);
            //Running
            if (Input.GetKey(KeyCode.LeftShift))
            {
                edAnimator.SetBool("isRunning", true);
                transform.position -= edRunBack * transform.forward * Time.deltaTime;
            }
        }
        else edAnimator.SetBool("isBackward", false);

        //Strafe Right animation

        if (Input.GetKey(KeyCode.D))
        {
            edAnimator.SetBool("isStrafeRight", true);
            transform.position += edSpeedBack * transform.right * Time.deltaTime;

        }
        else edAnimator.SetBool("isStrafeRight", false);

        //Strafe Left animation

        if (Input.GetKey(KeyCode.A))
        {
            edAnimator.SetBool("isStrafeLeft", true);
            transform.position -= edSpeedBack * transform.right * Time.deltaTime;
                 
        }
        else edAnimator.SetBool("isStrafeLeft", false);

        //Impulse Jump

        if (Input.GetKeyDown(KeyCode.Space))
        {
            edAnimator.SetBool("isJumpStart", true);
            rb.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
        }
        else edAnimator.SetBool("isJumpStart", false);

        //Mouse Rotation

        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal"), Space.World);

        //Throwing 

        if (Input.GetKeyDown(KeyCode.G))
        {
            edAnimator.SetBool("isThrow", true);
            Instantiate(bulletCloneTemplate, transform.position, transform.rotation);
        }
        else edAnimator.SetBool("isThrow", false);


    }
}
