using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class RobotControl : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float rotationSpeed = 180f;

    private Rigidbody2D rb;
    private float moveInput;
    private float rotateInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = Input.GetAxis("Vertical");
        rotateInput = -Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (Vector2)transform.up * moveInput * moveSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation + rotateInput * rotationSpeed * Time.fixedDeltaTime);
    }
}
