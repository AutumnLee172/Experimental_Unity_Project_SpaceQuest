using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Template_Dialogue : MonoBehaviour
{

    public DialogueTrigger diaolguetrig;
    // Start is called before the first frame update
    void Start()
    {
        diaolguetrig.TriggerDialogue();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
