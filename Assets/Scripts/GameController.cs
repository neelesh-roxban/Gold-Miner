using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
   public static GameController instance;
   
   public GameObject hookSlot;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }


    }
    private void Start()
    {
        
    }
    
}
