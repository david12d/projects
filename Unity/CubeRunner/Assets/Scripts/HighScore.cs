using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class HighScore : MonoBehaviour
{
    static int highscore;
    public static int score;
    public Text scoreText;
    Text text;
 
     // Set highscoreText up in the inspector.
     public Text highscoreText;

    [InitializeOnLoad]
    public class Startup
    {
        static Startup()
        {
            PlayerPrefs.SetInt("highscore", 0);
        }
    }

    private void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore");
    }

    void FixedUpdate()
     {
        score = int.Parse(scoreText.text);
         if (score > highscore)
         {
             highscore = score;
             PlayerPrefs.SetInt("highscore", highscore);
             highscoreText.text = "High score: " + highscore;
         }
         text.text = "High score: " + highscore;
     }

 
}
