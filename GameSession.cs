using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{

    [SerializeField] GameObject deadCanvas;
    int gemCount;

  public void Dead()
    {
        deadCanvas.SetActive(true);
        deadCanvas.GetComponent<Animator>().SetBool("Dead", true);
    }

 public void AddGem()
    {
        gemCount += 1;
        if (gemCount == 4)
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene + 1);
        }
    }

 public void ResetGem()
    {
        gemCount = 0;
    }
    public void LoadNextScene1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }


}
