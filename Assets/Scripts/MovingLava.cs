using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLava : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
 //   private Animator animator;
    private Vector3 change;
    // Start is called before the first frame update
    void Start()
    {
        change.y = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector2.zero)
            rb.velocity = Vector2.zero;
        change.Normalize();
        rb.MovePosition(transform.position + change * moveSpeed * Time.deltaTime);
    }
}
