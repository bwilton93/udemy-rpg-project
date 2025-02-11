using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float xInput;
    public float moveSpeed;
    public float jumpHeight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
        if (Input.GetKeyDown(KeyCode.Space)){
            JumpImpulse();
        }
    }

    void HorizontalMovement() 
    {
        xInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(xInput * moveSpeed, rb.linearVelocityY);
    }

    void JumpImpulse() 
    {
        rb.linearVelocityY = jumpHeight;
    }
}
