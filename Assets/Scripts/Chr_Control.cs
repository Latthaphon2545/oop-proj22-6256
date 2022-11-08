using UnityEngine;
using UnityEngine.Events;

public class Chr_Control : MonoBehaviour
{
    [SerializeField] private float motion_JumpForce = 400f;                          
    [Range(0, 1)][SerializeField] private float motion_CrouchSpeed = .36f;           
    [Range(0, .3f)][SerializeField] private float motion_MovementSmoothing = .06f;   
    [SerializeField] private bool motion_AirControl = false;                         
    [SerializeField] private LayerMask motion_WhatIsGround;                          
    [SerializeField] private Transform motion_CheckGround;                           
    [SerializeField] private Transform motion_CheckCeiling;                          
    [SerializeField] private Collider2D motion_CrouchDisableCollider;
    

    const float constant_GroundedRadius = .2f; 
    [HideInInspector]
    public bool motion_Grounded;            
    const float constant_CeilingRadius = .2f; 
    private Rigidbody2D motion_Rigidbody2D;
    private bool motion_FacingRight = true;  
    private Vector3 motion_Velocity = Vector3.zero;

    
    public float hangTime = 0.2f;
    private float hangCounter;

    public ParticleSystem impactEffect;

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;

    [System.Serializable]
    public class BoolEvent : UnityEvent<bool> { }

    public BoolEvent OnCrouchEvent;
    private bool m_wasCrouching = false;




    private void Awake()
    {
        motion_Rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();

        if (OnCrouchEvent == null)
            OnCrouchEvent = new BoolEvent();
    }

    private void Update()
    {
        if (motion_Grounded)
        {
            hangCounter = hangTime;
        }
        else
        {
            hangCounter -= Time.deltaTime;
        }

    }

    private void FixedUpdate()
    {
        bool wasGrounded = motion_Grounded;
        motion_Grounded = false;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(motion_CheckGround.position, constant_GroundedRadius, motion_WhatIsGround);
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject)
            {
                motion_Grounded = true;
                if (!wasGrounded)
                    OnLandEvent.Invoke();
            }
        }
    }


    public void Move(float move, bool crouch, bool jump, bool stopJump)
    {
        if (!crouch)
        {
            if (Physics2D.OverlapCircle(motion_CheckCeiling.position, constant_CeilingRadius, motion_WhatIsGround))
            {
                crouch = true;
            }
        }

        if (motion_Grounded || motion_AirControl)
        {

            if (crouch)
            {
                if (!m_wasCrouching)
                {
                    m_wasCrouching = true;
                    OnCrouchEvent.Invoke(true);
                }
                move *= motion_CrouchSpeed;

                if (motion_CrouchDisableCollider != null)
                    motion_CrouchDisableCollider.enabled = false;
            }
            else
            {
                if (motion_CrouchDisableCollider != null)
                    motion_CrouchDisableCollider.enabled = true;

                if (m_wasCrouching)
                {
                    m_wasCrouching = false;
                    OnCrouchEvent.Invoke(false);
                }
            }
            Vector3 targetVelocity = new Vector2(move * 10f, motion_Rigidbody2D.velocity.y);
            motion_Rigidbody2D.velocity = Vector3.SmoothDamp(motion_Rigidbody2D.velocity, targetVelocity, ref motion_Velocity, motion_MovementSmoothing);
            if (move > 0 && !motion_FacingRight)
            {
                Flip();
            }
            else if (move < 0 && motion_FacingRight)
            {
                Flip();
            }
        }


        if (hangCounter > 0 && jump)
        {
            impactEffect.Play();
            motion_Grounded = false;
            motion_Rigidbody2D.AddForce(new Vector2(0f, motion_JumpForce));
            hangCounter = 0;
        }

        if (motion_Rigidbody2D.velocity.y > 0 && stopJump)
        {
            motion_Rigidbody2D.velocity = new Vector2(motion_Rigidbody2D.velocity.x, motion_Rigidbody2D.velocity.y * .5f);
        }


    }


    private void Flip()
    {
        motion_FacingRight = !motion_FacingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
