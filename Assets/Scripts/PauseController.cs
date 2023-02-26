using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject txtInstructions;

    bool gamePaused = false;

    private void Start()
    {
        Unpause();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gamePaused)
            {
                Unpause();
            }
            else
            {
                Pause();
            }

            gamePaused = !gamePaused;
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
        panelPause.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        txtInstructions.SetActive(false);
    }

    public void Unpause()
    {
        Time.timeScale = 1.0f;
        panelPause.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        txtInstructions.SetActive(true);
    }
}
