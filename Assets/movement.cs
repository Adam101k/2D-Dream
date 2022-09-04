using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float moveHorizontal;
    float moveVertical;
    public float speed = 10f;
    public float jumpPower = 2f;
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");
        Jump();
        rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
    }

    private void Jump() {
        if(Input.GetButtonDown("Jump")) {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
}
