using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text highScoreText;

    void Start()
    {
        highScoreText.text = DataManager.Instance.highScoresText;
    }
}
