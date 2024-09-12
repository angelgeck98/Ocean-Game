using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseMenu : MonoBehaviour

{

    public static bool GameIsPaused = false; //Just checking if game is paused or not

    public GameObject pausedMenuUI;

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {


            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }


    public void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false; 
    }

    void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        ScenesManager.Instance.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Debug.Log("Quitting!!");
        Application.Quit();
    }

}

