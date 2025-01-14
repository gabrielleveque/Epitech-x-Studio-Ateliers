using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Animator animator;

    public float horizontal;
    public float speed = 5f;
    public float jumpingPower = 9f;
    public bool isFacingRight = true;
    public Rigidbody2D rb2d;
    public bool isGrounded = true;

    [SerializeField] public Rigidbody2D rb;
    [SerializeField] public Transform groundCheck;
    [SerializeField] public LayerMask groundLayer;
    public GameObject SpawnPointMuseumToHub;
    public GameObject SpawnPointHubToMuseum;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isRunning", false);
            rb.linearVelocity = new Vector2 (rb.linearVelocity.x, jumpingPower);
        }

        if (!isGrounded && rb.linearVelocity.y < 0)
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isFalling", true);
        }

        if (isGrounded && rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0)
        {
            animator.SetBool("isFalling", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", false);
        }

        if (isGrounded && rb.linearVelocity.x != 0 && rb.linearVelocity.y == 0)
        {
            animator.SetBool("isFalling", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isRunning", true);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2 (horizontal * speed, rb.linearVelocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "AccessToHub")
        {
            SceneManager.LoadScene("Hub");
            DontDestroyOnLoad(transform.gameObject);
            transform.position = SpawnPointMuseumToHub.transform.position;
        }
        if (other.gameObject.tag == "AccessToMuseum")
        {
            SceneManager.LoadScene("Museum");
            DontDestroyOnLoad(transform.gameObject);
            transform.position = SpawnPointHubToMuseum.transform.position;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground" && !isGrounded)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && isGrounded){
            isGrounded = false;
        }
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f ||!isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
