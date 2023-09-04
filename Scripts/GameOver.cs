using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public static bool timeout = false;

    [SerializeField] GameObject TimeoutScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (timeout)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

   public void ResumeGame()
    {
        TimeoutScreen.SetActive(false);
        Time.timeScale = 1f;
        timeout = false;
    }
    void PauseGame()
    {
        TimeoutScreen.SetActive(true);
        Time.timeScale = 0f;
        timeout = true;
    }
   public void RestartGame()
    {
        
        ScoreTracker.Score = 0;

    }
}
