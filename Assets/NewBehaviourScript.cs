using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;
    bool touchingplatform;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 10;
        touchingplatform = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = rb.velocity;

        if ( Input.GetKeyDown(KeyCode.Space) && (touchingplatform == true) )
        {
            vel.y = 15;
        }
        if (Input.GetKeyDown("down"))
        {
            vel.y = -10;
        }
        if (Input.GetKey("left"))
        {
            vel.x = -10;
        }
        if (Input.GetKey("right"))
        {
            vel.x = 10;
        }
        if (Input.GetKeyDown("w"))
        {
            vel.y = 10;
        }
        if (Input.GetKeyDown("s"))
        {
            vel.y = -10;
        }
        if (Input.GetKey("a"))
        {
            vel.x = -10;
        }
        if (Input.GetKey("d"))
        {
            vel.x = 10;
        }

        rb.velocity = vel;

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            touchingplatform = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            touchingplatform = false;
        }
    }
}

