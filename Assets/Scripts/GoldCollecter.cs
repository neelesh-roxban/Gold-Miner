using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoldCollecter : MonoBehaviour
{
    public GameObject hookSlot;
    private int score;
    public Text UIscore;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("a"))
        {
            Debug.Log("a");
            hookSlot.SetActive(false);
            score += 1;
            UIscore.text = score.ToString();
        }
    }
}
