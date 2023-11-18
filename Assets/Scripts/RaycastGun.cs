using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(LineRenderer))]
public class RaycastGun : MonoBehaviour
{
    public Camera playerCamera;
    public Transform laserOrigin;
    public TMPro.TextMeshProUGUI contadorTexto;
    public TMPro.TextMeshProUGUI textoMunicion;
    public Generador generador;
    public float gunRange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;
    private int shotsHit = 0;
    private int cubosDestruidos = 0;
    public int municion = 30;

    private string textoContador;

    private bool juegoTerminado = false;
    //public FirstPersonMovement firstPersonController;
    //public FirstPersonLook firstPersonLook;

    LineRenderer laserLine;
    float fireTimer;
 
    void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
    }
 
    void DetenerJuego()
    {
        Time.timeScale = 0;
        //firstPersonController.juegoPausado = true; 
        //firstPersonLook.juegoPausado = true;
    }

    public int Municion
    {
        get { return municion; }
        set
        {
            municion = value;
        }
    }

    void Update()
    {
        if(municion > 0){
            Disparar();           
        }
    }
 
    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }

    void Disparar(){
                fireTimer += Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && fireTimer > fireRate)
        {
            fireTimer = 0;
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit, gunRange))
            {
                laserLine.SetPosition(1, hit.point);

                // Comprueba si el objeto impactado tiene la etiqueta "Terreno"
                if (hit.transform.CompareTag("camion"))
                {
                    // Ignora el terreno y no hace nada
                }
                else if (hit.transform.CompareTag("zombi"))
                {
                    // Si es un cubo, se destruye con 2 disparos
                    shotsHit++;
                    if (shotsHit >= 3)
                    {
                    Destroy(hit.transform.gameObject);
                        shotsHit = 0;
                            cubosDestruidos++;

                            
                        //generador.GenerarObjeto("Cubo");
                    }
                }


            }
            else
            {
                laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
            }
            StartCoroutine(ShootLaser());
            municion = municion-1;
            textoMunicion.text = municion.ToString();
        }
    }

    
}