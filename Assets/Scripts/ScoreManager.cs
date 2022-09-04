using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public string nombre;
    public int score = 0;
    public int maxScore = 0;
    public string mejorPlayer;

    //Singletone para mantener la instancia del score
    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
       
        DontDestroyOnLoad(gameObject);
        LoadNameScore();
    }

    [System.Serializable]
    class saveData
    {
        public string nameData; //nombre actual
        public int scoreData;   //score actual
        public string mejorPlayerData;  //nombre con mas puntuacion
        public int maxScoreData;   //maxima puntuacion 
    }

    public void SaveNameScore()
    {
        string path = Application.dataPath + "/score.json";
        saveData saveData = new saveData();

        saveData.nameData = nombre;
        saveData.scoreData = score;
        saveData.mejorPlayerData = mejorPlayer;
        saveData.maxScoreData = maxScore;

        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(path , json);
    }

    public void LoadNameScore()
    {
        string path = Application.dataPath + "/score.json";
        
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            saveData data = JsonUtility.FromJson<saveData>(json);   

            nombre = data.nameData;
            score = data.scoreData;
            mejorPlayer = data.mejorPlayerData;
            maxScore = data.maxScoreData;
            return;
        }
    }
}
