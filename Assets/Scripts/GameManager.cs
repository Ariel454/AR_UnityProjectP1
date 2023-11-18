using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePause();
        }
    }

    void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0; // Pausa el tiempo en el juego
            pauseMenu.SetActive(true); // Muestra el menú de pausa
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1; // Reanuda el tiempo en el juego
            pauseMenu.SetActive(false); // Oculta el menú de pausa
        }
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1; // Reanuda el tiempo en el juego
        pauseMenu.SetActive(false); // Oculta el menú de pausa
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}