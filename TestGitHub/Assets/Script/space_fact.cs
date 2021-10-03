using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class space_fact : MonoBehaviour
{
    public string spacefact;
    public Text text;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            text.text = spacefact;
        }
        else
        {
            text.text = "";
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
       
            text.text = "";
        
    }
}
