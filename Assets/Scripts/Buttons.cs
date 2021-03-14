using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buttons : MonoBehaviour
{
   public GameObject menu;

    public void play()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
       
    }
    public void Pause()
    {
        menu.SetActive(true);
        Time.timeScale = 0;

    }
}
