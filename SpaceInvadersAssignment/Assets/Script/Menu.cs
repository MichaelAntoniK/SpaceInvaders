using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

    public void OnStartButtonClick()
    {
        Debug.Log("I was clicked");
        SceneManager.LoadScene("Lab1C2.0");
    }
    public void OnExitButtonClick()
    {
        Debug.Log("I was clicked");
        SceneManager.LoadScene("Menu");
    }

}
