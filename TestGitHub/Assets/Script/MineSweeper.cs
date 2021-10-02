using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MineSweeper : MonoBehaviour
{
    public string sceneToLoad;
    private int score = 0;
    public Animator UIanimator;
    public Text Text;
    public Text taskcomplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 10)
        {
            taskcomplete.text = "Task Complete!!";
            Invoke("ChangeScene", 3);
        }
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

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
