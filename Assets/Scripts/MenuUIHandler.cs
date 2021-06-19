using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); 
    #endif
    }

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void HighScore()
    {
        SceneManager.LoadScene(3);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void AddPlayerName(string userInput)
    {
        DataManager.Instance.playerName = userInput;
        DataManager.Instance.SaveData();
    }
}
