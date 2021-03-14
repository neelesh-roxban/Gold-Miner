using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    public float minz = -40f;
    public float maxz = 40f;
    public float rotateSpeed = 5f;
    private float rotateAngle;
    private bool  rotateRight;
    private bool canRotate;
    public float speed = 2f;
    private float startSpeed;
    public float minY = -11;
    private float startY;
    private bool moveDown;
    private Rope rope;
    public GameObject hookSlot;
    private void Awake()
    {
        rope = GetComponent<Rope>();
    }
    void Start()
    {
        startY = transform.position.y;
        startSpeed = speed;
        canRotate = true;
    }

    
    void Update()
    {
        rotate();
        GetInput();
        Movedown();
       
    }

    public void onCollectGold()
    {
        Debug.Log("goldCollected");
        
        hookSlot.SetActive(true);

    }

    public void onCollectRock()
    {
        Debug.Log("RockCollected");

        hookSlot.SetActive(false);
        moveDown = false;

    }

    void rotate()

    {
        if (!canRotate)
        {
            return;
        }

        if (rotateRight)
        {
            rotateAngle += rotateSpeed * Time.deltaTime;
        }
        else {
            rotateAngle -= rotateSpeed * Time.deltaTime;
        }
        transform.rotation = Quaternion.AngleAxis(rotateAngle, Vector3.forward);
        if (rotateAngle >= maxz)
        {
            rotateRight = false;
        }
        else if (rotateAngle <= minz)
        {
            rotateRight = true;
        }
        
    }

    void GetInput()
    {
        if (Input.touchCount> 0)
        {
            if (canRotate)
            {
                canRotate = false;

                moveDown = true;


            }
        }

    }
    void Movedown()
    {
        if (hookSlot.activeSelf)
        {
            moveDown = false;

        }
       


        if (canRotate )
        {
            return;
        }

        if (!canRotate)
        {
            Vector3 temp = transform.position;
            if (moveDown)
            {
                temp -= transform.up * Time.deltaTime * speed;
            }

            else
            {
                temp += transform.up * Time.deltaTime * speed;

            }
            transform.position = temp;
            if (temp.y <= minY)
            {
                moveDown = false;
            }
            if (temp.y >= startY)
            {
                canRotate = true;
                rope.Render(temp, false);

                speed = startSpeed;
            }
            rope.Render(temp, true);

        }


    }
}
