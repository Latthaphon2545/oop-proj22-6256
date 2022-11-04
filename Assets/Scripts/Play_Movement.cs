using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Chr_Control controllerScpt;
    public Animator mainAnim;
    public float runSpeed = 30f;
    float horizontalMove = 0f;
    bool jump = false;
    bool stopjump = false;

    public float jumpBufferLength = 0.5f;

    public ParticleSystem walkparticle;
    public int walkparticleRate = 12;
    private ParticleSystem.EmissionModule walkParEmission;




    private void Start()
    {
        walkParEmission = walkparticle.emission;
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        mainAnim.SetFloat("WalkSpeed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (horizontalMove != 0 && controllerScpt.motion_Grounded)
        {
            walkParEmission.rateOverTime = walkparticleRate;
        }
        else
        {
            walkParEmission.rateOverTime = 0f;
        }


        if (Input.GetButtonUp("Jump"))
        {
            stopjump = true;
        }
    }

    private void FixedUpdate()
    {
        controllerScpt.Move(horizontalMove * Time.fixedDeltaTime, false, jump, stopjump);
        jump = false;
        stopjump = false;
    }

}
