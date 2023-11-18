using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public string highScoresFileName = "highScores.json";

    private List<ScoreData> highScores = new List<ScoreData>();

    void Start()
    {
        LoadHighScores();
        // Puedes realizar alguna acción relacionada con los puntajes, como mostrarlos en la pantalla de inicio.
    }

    public void SaveScore(int score)
    {
        highScores.Add(new ScoreData(score));
        highScores.Sort((a, b) => b.score.CompareTo(a.score));

        if (highScores.Count > 10)
        {
            highScores.RemoveAt(10); // Limita la cantidad de puntuaciones almacenadas
        }

        SaveHighScores();
    }

    private void SaveHighScores()
    {
        string json = JsonUtility.ToJson(new ScoreList(highScores));
        System.IO.File.WriteAllText(Application.persistentDataPath + "/" + highScoresFileName, json);
    }

    private void LoadHighScores()
    {
        string filePath = Application.persistentDataPath + "/" + highScoresFileName;
        if (System.IO.File.Exists(filePath))
        {
            string json = System.IO.File.ReadAllText(filePath);
            ScoreList scoreList = JsonUtility.FromJson<ScoreList>(json);
            highScores = scoreList.scores;
        }
    }

    public List<ScoreData> GetHighScores()
    {
        return highScores;
    }
}

[System.Serializable]
public class ScoreList
{
    public List<ScoreData> scores;

    public ScoreList(List<ScoreData> scores)
    {
        this.scores = scores;
    }
}
