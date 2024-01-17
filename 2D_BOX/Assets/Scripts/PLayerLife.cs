using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerLife : MonoBehaviour
{
    public AudioClip deathSound; // Add this line to declare the audio clip

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an obstacle
        if (collision.transform.tag == "Obstacle")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);

            // Play the death sound effect
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
            Time.timeScale = 0;

            // You can add more logic here, such as game over screen or effects
        }
    }
}
