using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
    
{
 public void PlayGame()
    {
        var currentLevel = SceneManager.GetActiveScene().buildIndex;
        //if (currentLevel < 1)
        //{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
        //}
    }

}
