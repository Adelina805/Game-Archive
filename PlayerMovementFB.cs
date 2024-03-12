using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFB : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;
    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 14f;
    static readonly Vector3 right = new Vector3(1, 1, 1);
    static readonly Vector3 left = new Vector3(-1, 1, 1);

    // Instantiate components
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Move Character (left, right, jump)
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal Fire");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump Fire") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateCharacter();
    }

    // Flip character based on direction
    private void UpdateCharacter()
    {
        if (dirX > 0.1f)
        {
            transform.localScale = right;
        }
        else if (dirX < -0.1f)
        {
            transform.localScale = left;
        }
    }

    // Check if character is on the ground
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }
}
