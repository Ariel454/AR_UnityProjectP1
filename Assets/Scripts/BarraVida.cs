using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public GameObject textoGameOverParent;
    public TMPro.TextMeshProUGUI TextoGameOver;
    public float vidaTotal = 1.0f; // Total de vida

    float vidaActual; // Variable para almacenar la vida actual
    private int disparosRestantes = 10; // Número de disparos restantes antes de quedarse sin vida
    public Image barraVida; // Asegúrate de asignar la referencia al objeto Image de la barra de vida en el Inspector


    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            print("Daño");
            RecibirDanio();
        }
    }



    void RecibirDanio()
    {   
        if(vidaTotal != 0){
            vidaTotal = vidaTotal-0.1f;
            barraVida.fillAmount = vidaTotal;     
            if(vidaTotal <= 0.0001f){
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
}
