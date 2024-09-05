using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseMenu : MonoBehaviour

{
    [SerializeField] Button _BackToMainMenu;
    [SerializeField] GameObject _pauseMenu; 

    private bool _isPaused = false; //track if paused

    // Start is called before the first frame update
    void Start()
    {
        if(_BackToMainMenu == null)
        {
            Debug.LogError("ibuttin is not assigned"); 
            return;
        }

         _BackToMainMenu.onClick.AddListener(BackToMainMenu);

         _pauseMenu.SetActive(false);
    }

    void Update()
    {
         if(Input.GetKeyDown(KeyCode.Escape))
         {
            TogglePauseMenu();
         }
    }

    private void BackToMainMenu()
    {
        if(ScenesManager.Instance != null)
        {
            ScenesManager.Instance.LoadScene("MainMenu");
        }
        else 
        {
            Debug.LogError("Scene instance is null");
        }
       
    }

    private void TogglePauseMenu()
    {
        _isPaused = !_isPaused; //this is the paused state
        _pauseMenu.SetActive(_isPaused); // show or hide menu
        Time.timeScale = _isPaused ? 0 : 1; //pause or unpause
    }
}
