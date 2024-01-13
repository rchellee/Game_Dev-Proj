using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField]
    Image _loadingBar; 

    IEnumerator LoadNextLevel()
    {
        AsyncOperation loadLevel = SceneManager.LoadSceneAsync(1);

        while (!loadLevel.isDone)
        {
            float progressValue = Mathf.Clamp01(loadLevel.progress /.9f);
            _loadingBar.fillAmount = progressValue;
            yield return null;
        }
    }

    private void Start()
    {
        StartCoroutine(LoadNextLevel());
    }

}
