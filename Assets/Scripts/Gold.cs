using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    GameObject claw;
    Hook hook;
    Rigidbody2D rb;
    Vector3 moveDir;
    float speed;
    public int direction;


   
    public void Start()
    {
        claw = GameObject.FindGameObjectWithTag("claw");
        hook = claw.GetComponent<Hook>();

        speed = Random.Range(2, 4);
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
            hook.onCollectGold();
            Destroy(gameObject);

        }
        if (collision.gameObject.tag.Equals("edge"))
        {
            
            Destroy(gameObject);

        }
    }
}
