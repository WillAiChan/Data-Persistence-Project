using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public int score;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadData();
    }

    [System.Serializable]
    class Data
    {
        public string playerName;
        public int score;
    }

    public void SaveData()
    {
        Data data = new Data();
        data.playerName = playerName;
        data.score = score;

        string json = JsonUtility.ToJson (data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Data data = JsonUtility.FromJson<Data>(json);

            playerName = data.playerName;
            score = data.score;
        }
    }
}