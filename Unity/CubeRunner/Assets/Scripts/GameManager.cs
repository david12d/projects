using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameHasEnded = false;
    public float Restartdelay = 1;
    public GameObject CompleteLevelUI;
    public PlayerMovement movement;
    public GameObject StartLevelUI;


    public void LevelStart()
    {
        StartLevelUI.SetActive(false);
    }

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON!");
        StartLevelUI.SetActive(false);
        CompleteLevelUI.SetActive(true);
        gameHasEnded = true;
    }
    
    public void GameOver()
    {
          
        if(gameHasEnded == false)
        {

            gameHasEnded = true;
            PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Death Screen");
            // Invoke("Restart", 1);
        }
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        movement.enabled  = true;

    }

}
