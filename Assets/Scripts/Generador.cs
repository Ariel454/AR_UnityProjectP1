using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject zombiePrefab;

    public GameObject tacho1;
    public GameObject tacho2;
    public GameObject tacho3;
    public GameObject mesa;
    public GameObject papel;
    public GameObject cereal;
    public GameObject ladrillo;
    public GameObject bottle1;
    public GameObject battery;
    public GameObject bottle2;
    public float minX = 0f;
    public float maxX = 100f;
    public float minY = 0f;
    public float maxY = 0f;
    public float minZ = 0f;
    public float maxZ = 100f;

    public int cantidadInicialzombies = 20;
    public int cantidadInicialbasura = 20;



    private int zombiesGenerados = 0;
    private int basuraGenerada = 0;


    void Start()
    {
        // Genera la cantidad inicial de cubos y esferas al inicio
        GenerarObjetos("zombi", cantidadInicialzombies);
        GenerarObjetos("tacho1", cantidadInicialbasura);
        GenerarObjetos("tacho2", cantidadInicialbasura);
        GenerarObjetos("tacho3", cantidadInicialbasura);
        GenerarObjetos("bottle1", cantidadInicialbasura);
        GenerarObjetos("bottle2", cantidadInicialbasura);
        GenerarObjetos("battery", cantidadInicialbasura);
        GenerarObjetos("mesa", cantidadInicialbasura);
        GenerarObjetos("papel", cantidadInicialbasura);
        GenerarObjetos("cereal", cantidadInicialbasura);
        GenerarObjetos("ladrillo", cantidadInicialbasura);
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

        if (tipo == "zombi" && zombiesGenerados < 100000)
        {
            nuevoObjeto = Instantiate(zombiePrefab, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "zombi";
            zombiesGenerados++;
        }
        else if(tipo == "tacho1" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(tacho1, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "tacho1";
            basuraGenerada++;
        }
        else if(tipo == "tacho2" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(tacho2, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "tacho2";
            basuraGenerada++;
        }
        else if(tipo == "tacho3" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(tacho3, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "tacho3";
            basuraGenerada++;
        }
        else if(tipo == "bottle1" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(bottle1, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "bottle1";
            basuraGenerada++;
        }
        else if(tipo == "bottle2" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(bottle2, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "bottle2";
            basuraGenerada++;
        }
        else if(tipo == "battery" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(battery, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "battery";
            basuraGenerada++;
        }
        else if(tipo == "mesa" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(mesa, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "mesa";
            basuraGenerada++;
        }
        else if(tipo == "papel" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(papel, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "papel";
            basuraGenerada++;
        }
        else if(tipo == "cereal" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(cereal, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "cereal";
            basuraGenerada++;
        }
        else if(tipo == "ladrillo" && basuraGenerada < 100000)
        {
            nuevoObjeto = Instantiate(ladrillo, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
            nuevoObjeto.tag = "ladrillo";
            basuraGenerada++;
        }
        
        
    }

}