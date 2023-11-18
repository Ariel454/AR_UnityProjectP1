using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class ScoreSceneController : MonoBehaviour
{
    public ScoreManager scoreManager;
    public TMPro.TextMeshProUGUI highScoresText;

    void Start()
    {
        MostrarHighScores();
    }

    void MostrarHighScores()
    {
        List<ScoreData> highScores = scoreManager.GetHighScores();

        if (highScores != null && highScores.Count > 0)
        {
            string scoresText = "High Scores:\n";

            for (int i = 0; i < highScores.Count; i++)
            {
                scoresText += $"{i + 1}. {highScores[i].score}\n";
            }

            highScoresText.text = scoresText;
        }
        else
        {
            highScoresText.text = "No hay puntajes aún.";
        }
    }
}
