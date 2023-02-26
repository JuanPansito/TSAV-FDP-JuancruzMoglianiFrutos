using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene("Scene1(probuilder)");
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene("Scene2(assets)");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
