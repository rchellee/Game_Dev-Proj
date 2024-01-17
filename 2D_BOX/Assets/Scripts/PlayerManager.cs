using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    
    public GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);

        }
       
    }
    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void menu(){
        SceneManager.LoadScene("Menu");
    }
    public void quit()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}