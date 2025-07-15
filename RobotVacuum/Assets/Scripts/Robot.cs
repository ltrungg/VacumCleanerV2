using UnityEngine;

public class Robot : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private Vector2 lastDirection = Vector2.up; // default looking up
    private GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true; // prevent physics from rotating the body
    }

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    void Update()
    {
        ProcessInputs();

        if (moveDirection != Vector2.zero)
            lastDirection = moveDirection;

        RotateSprite();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D 
        float moveY = Input.GetAxisRaw("Vertical");   // W/S  
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        rb.linearVelocity = moveDirection * moveSpeed;
    }

    void RotateSprite()
    {
        float angle;

        if (Mathf.Abs(lastDirection.x) > Mathf.Abs(lastDirection.y))
        {
            angle = lastDirection.x > 0f ? -90f : 90f;
        }
        else
        {
            angle = lastDirection.y > 0f ? 0f : 180f;
        }

        transform.localEulerAngles = new Vector3(0f, 0f, angle);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Garbage"))
        {
            Destroy(collision.gameObject);
            gameManager.AddScore(1);
        }
    }
}
