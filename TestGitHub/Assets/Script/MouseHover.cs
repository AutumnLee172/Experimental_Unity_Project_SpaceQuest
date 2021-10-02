using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator Ship_text;
    bool onPointerEnter = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(onPointerEnter == true)
        {
            Ship_text.SetBool("IsHover", true);
           
        }
        else if(onPointerEnter == false)
        {
            Ship_text.SetBool("IsHover", false);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        onPointerEnter = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        onPointerEnter = false;
    }

}
