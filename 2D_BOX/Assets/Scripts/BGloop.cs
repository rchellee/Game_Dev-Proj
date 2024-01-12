using UnityEngine;

public class BGloop : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 startPosition;
    private bool gameIsOver = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Check if the game is over before updating the background position
        if (!gameIsOver)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    // Function to set the game over state
    public void GameOver()
    {
        gameIsOver = true;
    }

    // Function to reset the background position
    public void ResetBackground()
    {
        gameIsOver = false;
        transform.position = startPosition;
    }
}
