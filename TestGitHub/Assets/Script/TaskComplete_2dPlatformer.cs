using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TaskComplete_2dPlatformer : MonoBehaviour
{
    public string sceneToLoad;
    public Text text;
    public Text completetext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (text.text == "6")
        {
            completetext.text = "Task complete!!!";
            Invoke("ChangeScene", 2);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
