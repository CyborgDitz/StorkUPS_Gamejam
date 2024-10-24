using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScripts : MonoBehaviour
{
    public string GameWorld;
    public string loadCredits;

    public string MainMenu;
    public string exitGame;

    void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(MainMenu);
    }
    
    //start game scene
    public void startGameButton()
    {
        SceneManager.LoadScene(GameWorld);
    }

    
    //Loading credits scene
    public void loadCreditsButton()
    {
        SceneManager.LoadScene(loadCredits);
    }
    
    //Close game button.
    public void QuitGameButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quit button pressed");
#endif

        Application.Quit();
    }
}
