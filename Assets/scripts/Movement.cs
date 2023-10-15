using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator animator;
    
    private Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal",movement.x);
        animator.SetFloat("vertical",movement.y);
        animator.SetFloat("speed",movement.sqrMagnitude);

    }
    private void FixedUpdate() {
        rb.MovePosition(rb.position + movement * speed* Time.fixedDeltaTime);   
    }
}
