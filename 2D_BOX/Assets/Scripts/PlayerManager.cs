using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public static bool CompleteLevel;
    public GameObject gameOverScreen;
    public GameObject completeLevelScreen;
    public Timer timerScript; // Reference to your Timer script

    private void Awake()
    {
        isGameOver = false;
        CompleteLevel = false;
    }

    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);

            // Display the final time on game over screen
            if (timerScript != null)
            {
                timerScript.DisplayFinalTime();
            }
        }

        if (CompleteLevel)
        {
            completeLevelScreen.SetActive(true);
            if (timerScript != null)
            {
                timerScript.DisplayFinalTime();
            }
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("exit");
    }

    
}