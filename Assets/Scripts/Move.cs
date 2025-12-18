using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float mainl;

    public bool facingRight = true;

    public float speed = 7f;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mainl = Input.GetAxis("Horizontal");

        if (mainl < 0 && facingRight)
        {
            flip();
        }
        else if (mainl > 0 && !facingRight)
        {
            flip();
        }

    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(mainl * speed, rb.linearVelocity.y);
    }


    void flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
