using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float startingSpeed = 100.0f;

    [SerializeField]
    private float jumpForce = 10.0f;

    private new Rigidbody2D rigidbody2D;

    private bool canJump;

    private bool hasStarted;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        hasStarted = false;

        AddStartingForce();

        hasStarted = true;
    }

    private void AddStartingForce()
    {
        rigidbody2D.AddForce(Vector2.right * startingSpeed);

        GameObject.FindObjectOfType<AnimationController>().Run();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && canJump)
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            GameObject.FindObjectOfType<AnimationController>().Jump();

            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        HandleGroundCollision(collision2D);
    }

    private void HandleGroundCollision(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Ground"))
        {
            canJump = true;

            if (hasStarted)
            {
                GameObject.FindObjectOfType<AnimationController>().Run();
            }
        }
    }
}
