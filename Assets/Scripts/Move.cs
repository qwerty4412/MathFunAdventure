using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float mainl;

    public bool facingRight = true;

    public float speed = 7f;

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        mainl = Input.GetAxis("Horizontal");

        if (mainl < 0 && facingRight)
        {
            flip();
        }
        else if (mainl > 0 && facingRight)
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
        if(!facingRight)
        transform.localRotation = Quaternion.Euler(0,90,0);
        else transform.localRotation = Quaternion.Euler(0,-90,0);
        facingRight = !facingRight;
    }
}
