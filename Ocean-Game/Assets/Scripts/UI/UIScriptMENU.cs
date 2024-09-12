using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    
   
    // Update is called once per frame
    public void StartNewGame()
    {
        ScenesManager.Instance.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting!!");
        Application.Quit();
    }


}
