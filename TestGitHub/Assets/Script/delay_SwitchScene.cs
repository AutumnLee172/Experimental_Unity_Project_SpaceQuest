using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class delay_SwitchScene : MonoBehaviour
{
    public string sceneToLoad;
    public int delayTime;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ChangeScene", delayTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
