using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    
    private float horizontal;
    private float speed = 16f;
    private float jumpingPower = 22f;
    private bool isFacingRight = true;


    private float coyoteTime = 0.2f;
    private float coyoteTimeCounter;

    float horizontalMove = 0f;

    [SerializeField] Player_Death playerDeathScript;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] Animator PlayerAnimator;
    [SerializeField] private Collider2D Coll;

    private void Start()
    {
        PlayerAnimator ??= GetComponent<Animator>();
        Coll ??= GetComponent<Collider2D>();
    }
    void Update()
    {
        if (playerDeathScript.IsDeath)
        {
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");

        if (IsGrounded())
        {
            coyoteTimeCounter = coyoteTime;
        }
        else
        {
            coyoteTimeCounter -= Time.deltaTime;
        }


        if (coyoteTimeCounter > 0f && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);

            coyoteTimeCounter = 0f;
        }

        Flip();
    }

    private void FixedUpdate()
    {
        if (playerDeathScript.IsDeath)
        {
            return;
        }
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        PlayerAnimator.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        PlayerAnimator.SetBool("Grounded", IsGrounded());
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(transform.position + (Vector3)Coll.offset, new Vector2(3.53f, 3f), 0f, -transform.up, 1f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}