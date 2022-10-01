using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball1 : MonoBehaviour
{

    public float speed = 75f;
    public Vector3 startPos = new Vector3(0, -3.5f, 0);

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        respawn();
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -5)
                respawn();
    }

    void respawn()
    {
        gameObject.transform.position = startPos;
        rb.velocity = new Vector3(0, 0, 0);
        rb.AddForce(new Vector2(Random.Range(-2f, 2f), 1).normalized * speed);
    }
}
