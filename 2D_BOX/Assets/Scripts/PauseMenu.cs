using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] AudioSource backgroundMusic;

    private bool isPaused = false;

    private void Update()
    {
        // Check for space key press to toggle pause or show pause menu
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void OpenPauseMenu()
    {
        if (!isPaused)
        {
            Pause();
        }
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;

        // Pause the background music
        if (backgroundMusic != null)
        {
            backgroundMusic.Pause();
        }

        isPaused = true;
    }

    public void Home()
    {
        SceneManager.LoadScene(1);
        Resume(); // Ensure timeScale is set to 1 before loading a new scene
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;

        // Resume the background music if it was paused
        if (backgroundMusic != null && isPaused)
        {
            backgroundMusic.UnPause();
        }

        isPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

        // Resume the background music if it was paused
        if (backgroundMusic != null && isPaused)
        {
            backgroundMusic.UnPause();
        }

        isPaused = false;
    }
}
