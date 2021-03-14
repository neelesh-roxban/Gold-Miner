using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    GameObject claw;
    Hook hook;
    Vector3 moveDir;
    float speed;
    public int direction;
    Rigidbody2D rb;

    private void Start()
    {
        claw = GameObject.FindGameObjectWithTag("claw");
        hook = claw.GetComponent<Hook>();
        speed = Random.Range(1, 3);
        moveDir.x = direction;
        moveDir.y = 0;
        moveDir.z = 0;
        rb = GetComponent<Rigidbody2D>();
       
    }
    private void FixedUpdate()
    {
        rb.velocity = moveDir * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("claw"))
        {
            hook.onCollectRock();
            Destroy(gameObject);

        }
        if (collision.gameObject.tag.Equals("edge"))
        {

            Destroy(gameObject);

        }

    }
}
