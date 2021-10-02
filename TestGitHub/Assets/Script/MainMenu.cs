using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    //trying to use a different method for ui, but it's more complicated, not using it rn *start* 
    //public GameObject ui_canvas;
    //GraphicRaycaster ui_raycaster;

    //PointerEventData click_data;
    //List<RaycastResult> click_results;

    //void Start()
    //{
    //    ui_raycaster = ui_canvas.GetComponent<GraphicRaycaster>();
    //    click_data = new PointerEventData(EventSystem.current);
    //    click_results = new List<RaycastResult>();

    //}

    //void Update()
    //{
    //    if (Mouse.current.leftButton.wasReleasedThisFrame)
    //    {
    //        GetUiElementsClicked();
    //    }        
    //}

    //void GetUiElementsClicked()
    //{
    //    click_data.position = Mouse.current.position.ReadValue();
    //    click_results.Clear();

    //    ui_raycaster.Raycast(click_data, click_results);

    //    foreach (RaycastResult result in click_results)
    //    {
    //        GameObject ui_element = result.gameObject;

    //        Debug.Log(ui_element.name);
    //    }
    //}
    //trying to use a different method for ui, but it's more complicated, not using it rn *end* 

    //real MainMenu Ui function
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
