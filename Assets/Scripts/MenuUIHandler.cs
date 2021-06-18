using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public DataManager data;

    public TMP_Text bestScoreText;
    void Start()
    {
        bestScoreText.text = "Best Score: " + data.playerName + ": " + data.score;
    }

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
}
