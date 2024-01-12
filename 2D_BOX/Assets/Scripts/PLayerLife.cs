using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayerLife : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an obstacle
        if (collision.transform.tag=="Obstacle")
        {
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);

            // You can add more logic here, such as game over screen or effects
        }
    }

}
