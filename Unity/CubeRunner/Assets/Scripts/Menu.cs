using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        
        EditorSceneManager.LoadScene(1);
    }
    
}
