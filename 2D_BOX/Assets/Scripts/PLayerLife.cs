using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerLife : MonoBehaviour
{
    public AudioClip deathSound; // Add this line to declare the death sound effect
    public AudioSource backgroundMusicSource; // Reference to the AudioSource for background music

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an obstacle
        if (collision.transform.tag == "Obstacle")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);

            // Play the death sound effect
            AudioSource.PlayClipAtPoint(deathSound, transform.position);

            // Stop the background music
            if (backgroundMusicSource != null)
            {
                backgroundMusicSource.Stop();
            }

            Time.timeScale = 0;
        }
        // Check if the collision is with a flag
        if (collision.transform.tag == "Flag")
        {
            PlayerManager.CompleteLevel = true;
            gameObject.SetActive(false);

            // Play the death sound effect
            AudioSource.PlayClipAtPoint(deathSound, transform.position);

            // Stop the background music
            if (backgroundMusicSource != null)
            {
                backgroundMusicSource.Stop();
            }

            Time.timeScale = 0;
        }
    }

}