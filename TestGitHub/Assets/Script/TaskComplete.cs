using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskComplete : MonoBehaviour
{
    public string sceneToLoad;
    public Animator UIanimator;
    public Camera camera_follow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            Destroy(camera_follow.GetComponent<Camera_Follow>());
            Destroy(other.gameObject);
            UIanimator.SetBool("Is_Failed", true);
            Invoke("ChangeScene", 3);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
