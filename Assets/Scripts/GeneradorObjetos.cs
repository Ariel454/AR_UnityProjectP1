using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject FirstAid;

    public GameObject Potion;
    public GameObject Ammo;

    public float minX = 0f;
    public float maxX = 100f;
    public float minY = 0f;
    public float maxY = 0f;
    public float minZ = 0f;
    public float maxZ = 100f;

    public int cantidadObjetos = 20;

    private int objetosGenerados = 0;


    void Start()
    {
        // Genera la cantidad inicial de cubos y esferas al inicio
        GenerarObjetos("potion", cantidadObjetos);
        GenerarObjetos("firstaid", cantidadObjetos);
        GenerarObjetos("ammo", cantidadObjetos);
    }

    public void GenerarObjetos(string tipo, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            GenerarObjeto(tipo);
        }
    }

/*
    public void GenerarBasura(int tipo, int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            GenerarBasura(tipo);
        }
    }*/
    public void GenerarObjeto(string tipo)
    {
        GameObject nuevoObjeto = null;

        if (tipo == "potion" && objetosGenerados < 100000)
        {
            nuevoObjeto = Instantiate(Potion, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "potion";
            objetosGenerados++;
        }
        else if(tipo == "firstaid" && objetosGenerados < 100000)
        {
            nuevoObjeto = Instantiate(FirstAid, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "firstaid";
            objetosGenerados++;
        }
        else if(tipo == "ammo" && objetosGenerados < 100000)
        {
            nuevoObjeto = Instantiate(Ammo, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "ammo";
            objetosGenerados++;
        }

        
        
    }

}