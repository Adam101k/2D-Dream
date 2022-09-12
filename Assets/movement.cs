using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    private Rigidbody2D rb;
    Vector2 move;
    public float speed = 10f;
    public float jumpPower = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(move.x * speed, rb.velocity.y);
    }
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

}
