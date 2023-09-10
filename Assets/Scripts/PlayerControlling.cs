using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerControlling : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 7f;
    [SerializeField] float jumpForce = 5f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    [SerializeField] float checkRadius = 0.1f;
    //[SerializeField] float jumpTime = 0.1f;
    [SerializeField] AudioSource jumpSound;

    
    

    //float xInput;

    //bool facingRight;
    bool jump;
    bool isJumping;
    bool isGrounded;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (jump && !isJumping)
        {
            jump = false;
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        /*
        rb.velocity = new Vector3(xInput * moveSpeed, rb.velocity.y, 0f);
        
        //flipping the player
        if (xInput < 0 && facingRight)
        {
            flipPlayer();
        }
        else if (xInput > 0 && !facingRight)
        {
            flipPlayer();
        }
        */
        isGrounded = Physics.CheckSphere(groundCheck.position, checkRadius, groundLayer);

        if (!isGrounded && isJumping)
        {
            isJumping = false;
            return;
        }

        if (isGrounded && isJumping)
        {
            //rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0f);
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
            jumpSound.Play();
            isJumping = false;
        }
    }
/*
    void flipPlayer()
    {
        facingRight = !facingRight;

        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    public void HorizontalInput(float value)
    {
        xInput = value;
    }
*/
    public void JumpInput()
    {
        jump = true;
    }
}
