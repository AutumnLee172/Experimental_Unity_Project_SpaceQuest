using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineSweeper : MonoBehaviour
{
    private int score = 0;
    public Animator UIanimator;
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_AddPoint()
    {
        score++;
        Text.text = score.ToString();
        Debug.Log(score);       
    }

    public void OnClick_Destory()
    {
        Destroy(gameObject);
    }

    public void OnClick_Lose()
    {

        UIanimator.SetBool("Is_Failed", true);
    }
}
