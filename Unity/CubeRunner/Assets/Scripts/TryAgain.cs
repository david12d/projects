using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    
    public void Replay()
    {
        string sceneName = PlayerPrefs.GetString("lastLoadedScene");
        SceneManager.LoadScene(sceneName);//back to previous scene1?
    }

    void FixedUpdate()
    {

        if (Input.anyKey)
        {
            Replay();
        }

    }
}

