using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public string playerName;
    public string bestPlayerName ;
    public int bestPlayerScore = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            LoadHighScores();
            return;
        }
        Destroy(gameObject);
    }

    private void Start()
    {
        if (bestPlayerName == "") bestPlayerName = "John Doe";
    }

    void Update()
    {
        
    }

    public void StartGame(string inputName)
    {
        if (inputName == "") inputName = "Anonymous";
        playerName = inputName;
        SceneManager.LoadScene(1);
    }

    class DataToSave
    {
        public string bestPlayerName;
        public int bestPlayerScore;
    }

    public void LoadHighScores()
    {
        string path = Application.persistentDataPath + "/highscore.json";
        if(File.Exists(path))
        {
            DataToSave data = JsonUtility.FromJson<DataToSave>(File.ReadAllText(path));
            bestPlayerName = data.bestPlayerName;
            bestPlayerScore = data.bestPlayerScore;
        }
    }

    public void SaveHighScores()
    {
        DataToSave data = new DataToSave();
        data.bestPlayerName = bestPlayerName;
        data.bestPlayerScore = bestPlayerScore;
        string json = JsonUtility.ToJson(data);
        string path = Application.persistentDataPath + "/highscore.json";
        File.WriteAllText(path, json);
    }

}
