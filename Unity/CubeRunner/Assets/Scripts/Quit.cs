using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void KeepPlaying()
    {
        SceneManager.LoadScene("Level4");//back to previous scene1?       
        //EditorSceneManager.LoadScene(1);
    }
}
