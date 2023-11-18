using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{

    public TMPro.TextMeshProUGUI TextoMochila;
    public TMPro.TextMeshProUGUI TextoScore;
    public TMPro.TextMeshProUGUI TextoScoreFinal;
    public GameObject textoGameOverParent;
    public TMPro.TextMeshProUGUI TextoGameOver;
    private int basuraRecolectada = 0;
    public int maxBasuraEnMochila = 3;
    private int basuraEnMochila = 0;
    private int scoreActual = 0;
    public ScoreManager scoreManager; 
    public float tiempoLimite = 60.0f; 
    private float tiempoTranscurrido = 0.0f;
    private bool juegoTerminado = false;


   void Update()
    {
        // Verifica si el juego ya terminó
        if (!juegoTerminado)
        {
            // Actualiza el tiempo transcurrido
            tiempoTranscurrido += Time.deltaTime;

            // Verifica si el tiempo límite ha sido alcanzado
            if (tiempoTranscurrido >= tiempoLimite)
            {
                // Marca el juego como terminado
                juegoTerminado = true;

                // Realiza las acciones finales del juego
                if (scoreManager != null)
                {
                    scoreManager.SaveScore(scoreActual);
                }


                MostrarTextoGameOver();
            }
        }
    }

    void MostrarTextoGameOver()
    {
        // Activa el objeto de juego que contiene el TextMeshProUGUI
        textoGameOverParent.SetActive(true);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
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

            TextoScoreFinal.text = scoresText;
        }
        else
        {
            TextoScoreFinal.text = "No hay puntajes aún.";
        }
    }

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            print("Daño");
        }

        else if(coll.CompareTag("bottle1") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("bottle2") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("tacho1") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("tacho2") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("tacho3") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }       
        else if(coll.CompareTag("battery") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("cereal") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("papel") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("ladrillo") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("mesa") && basuraEnMochila < maxBasuraEnMochila)
        {
            basuraEnMochila++;
            Destroy(coll.gameObject); // Destruye el objeto de basura.
            TextoMochila.text = basuraEnMochila.ToString();
        }
        else if(coll.CompareTag("camion") && basuraEnMochila == 3)
        {
            scoreActual += 15;
            basuraEnMochila=0;
            TextoMochila.text = basuraEnMochila.ToString();
            TextoScore.text = scoreActual.ToString();
        }
        else if(coll.CompareTag("camion") && basuraEnMochila == 2)
        {
            scoreActual += 10;
            basuraEnMochila=0;
            TextoMochila.text = basuraEnMochila.ToString();
            TextoScore.text = scoreActual.ToString();
        }
        else if(coll.CompareTag("camion") && basuraEnMochila == 1)
        {
            scoreActual += 10;
            basuraEnMochila=0;
            TextoMochila.text = basuraEnMochila.ToString();
            TextoScore.text = scoreActual.ToString();
        }

    }



}
