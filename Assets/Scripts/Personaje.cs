using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    public float vidaTotal = 100.0f; // Total de vida
    public float vidaActual; // Variable para almacenar la vida actual
    public Image barraVida; // Asegúrate de asignar la referencia al objeto Image de la barra de vida en el Inspector

    void OnTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("arma"))
        {
            print("Daño");
            RecibirDanio(10.0f); // Reducir exactamente 10 puntos de vida por golpe
        }
    }

 void RecibirDanio(float cantidad)
{
    print("Vida antes del golpe: " + vidaActual);

    if (vidaActual > 0)
    {
        vidaActual -= cantidad; // Reduce la vida
        print("Vida después del golpe: " + vidaActual);
        ActualizarBarraVida(); // Actualiza la barra de vida

        if (vidaActual <= 0)
        {
            print("¡Vida agotada!");
            MostrarTextoGameOver(); // Mostrar Game Over solo si la vida se ha agotado
        }
    }
}


    void ActualizarBarraVida()
    {
        // Asegúrate de que la vidaActual no sea menor que cero
        vidaActual = Mathf.Max(vidaActual, 0f);

        // Calcula el valor de la barra de vida después de recibir daño
        float nuevoValorBarra = vidaActual / vidaTotal;

        // Asegúrate de que el nuevo valor esté en el rango [0, 1]
        nuevoValorBarra = Mathf.Clamp01(nuevoValorBarra);

        // Actualiza la barra de vida visualmente
        barraVida.fillAmount = nuevoValorBarra;
    }


    void MostrarTextoGameOver()
    {
        // Puedes agregar aquí la lógica para mostrar el Game Over
        // ...
    }
}
