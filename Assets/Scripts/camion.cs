using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camion : MonoBehaviour
{
    public float velocidad = 5f; // Puedes ajustar la velocidad desde el Inspector

    void Update()
    {
        // Mover el camión hacia adelante
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime, Space.World);
    }
}
