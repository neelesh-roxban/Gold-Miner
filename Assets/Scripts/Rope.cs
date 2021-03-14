using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    private LineRenderer line;
    public Transform startpoint;

    private float width = 0.05f;

    private void Awake()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = width;
        line.enabled = false;
    }
    void Start()
    {
        
    }

    public void Render(Vector3 endPosition,bool enableRenderer)
    {
        if (enableRenderer)
        {
            if (!line.enabled)
            {
                line.enabled = true;
            }

            line.positionCount = 2;
        }
        else
        {
            line.positionCount = 0;
            if (line.enabled)
            {
                line.enabled = false;
            }


        }
        if (line.enabled)
        {
            Vector3 temp = startpoint.position;
            temp.z = 0;
            startpoint.position = temp;
            temp = endPosition;
            temp.z = 0f;
            endPosition = temp;
            line.SetPosition(0, startpoint.position);
            line.SetPosition(1, endPosition);
            
        }
    }
   
}
