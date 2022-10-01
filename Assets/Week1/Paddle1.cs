using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle1 : MonoBehaviour
{
    public float speed = 10f;
    public float width = 3f;

    Rigidbody2D rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        gameObject.transform.localScale = new Vector3(width, 0.5f, 1);
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow)
                && gameObject.transform.position.x < 10.5 - (width / 2f))
            rb.MovePosition(gameObject.transform.position + new Vector3(speed * Time.fixedDeltaTime, 0, 0));

        if (Input.GetKey(KeyCode.LeftArrow)
                && gameObject.transform.position.x > -10.5 + (width / 2f))
            rb.MovePosition(gameObject.transform.position - new Vector3(speed * Time.fixedDeltaTime, 0, 0));

    }
}
