using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject zombiePrefab;
    public float minX = 0f;
    public float maxX = 100f;
    public float minY = 0f;
    public float maxY = 0f;
    public float minZ = 0f;
    public float maxZ = 100f;

    public int cantidadInicialzombies = 10;

    private int zombiesGenerados = 0;

    void Start()
    {
        // Genera la cantidad inicial de cubos y esferas al inicio
        GenerarObjetos("zombi", cantidadInicialzombies);
    }

    public void GenerarObjetos(string tipo, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            GenerarObjeto(tipo);
        }
    }

    public void GenerarObjeto(string tipo)
    {
        GameObject nuevoObjeto = null;

        if (tipo == "zombi" && zombiesGenerados < 100000)
        {
            nuevoObjeto = Instantiate(zombiePrefab, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "zombi";
            zombiesGenerados++;
        }
    }
}
