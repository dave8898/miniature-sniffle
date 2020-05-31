using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{

   [SerializeField] float secondsToWait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextSceneWithWait(secondsToWait));
    }

    private IEnumerator LoadNextSceneWithWait(float secondsToWait)
    {
        yield return new WaitForSecondsRealtime(secondsToWait);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
