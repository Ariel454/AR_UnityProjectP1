using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public GameObject textoGameOverParent;
    public TMPro.TextMeshProUGUI TextoGameOver;
    public TMPro.TextMeshProUGUI textoMunicion;
    public float vidaTotal = 1.0f; // Total de vida
    public RaycastGun arma;
    public FirstPersonMovement correr;

    float vidaActual; // Variable para almacenar la vida actual
    public Image barraVida; // Asegúrate de asignar la referencia al objeto Image de la barra de vida en el Inspector

    

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            //print("Daño");
            RecibirDanio();
        }
        else if(coll.CompareTag("firstaid")){
            if(vidaTotal < 0.999000f){
                Curar();  
                Destroy(coll.gameObject);      
            }   
            
        }
        else if(coll.CompareTag("ammo")){

            if(arma.Municion < 30)
            {
                Recargar();  
                Destroy(coll.gameObject);      
            }   
            
        }
        else if(coll.CompareTag("potion")){
            if(correr.RunSpeed < 11.00f){
                Correr();  
                Destroy(coll.gameObject);      
            }   
            
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

    void Curar()
    {   
            vidaTotal = vidaTotal+0.1f;
            barraVida.fillAmount = vidaTotal;     

    }

    void Recargar()
    {
        if (arma != null)
        {
            arma.Municion = 30;
            textoMunicion.text = "30";
        }
    }

    void Correr()
    {
        if (correr != null)
        {
            correr.RunSpeed = 15.0f;
            Invoke("RestaurarVelocidad", 5.0f);
        }
    }

    void RestaurarVelocidad()
    {
        if (correr != null)
        {
            correr.RunSpeed = 8.0f;
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
