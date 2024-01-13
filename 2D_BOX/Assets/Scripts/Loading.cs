using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public float delay = 3f; // Adjust as needed
    [SerializeField] private Image _loadingBar; 

    private void Start()
    {
        StartCoroutine(LoadNextLevel());
    }
    private IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(delay);
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync(1);

        while (!loadLevel.isDone)
        {
            float progressValue = Mathf.Clamp01(loadLevel.progress /.5f);
            _loadingBar.fillAmount = progressValue;
            yield return null;
        }
    }

}
