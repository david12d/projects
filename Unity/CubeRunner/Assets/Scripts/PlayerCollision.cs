using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public AudioClip crash;
    bool waitActive = false;

    //private AudioSource source = ;

    private void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = crash;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.tag);
        // Check if object we collided with an Obstacle
        if (collisionInfo.gameObject.tag.Contains("Obstacle"))
        {
            movement.enabled = false;     // Disables player movement
            GetComponent<AudioSource>().Play();

            if (!waitActive)
            {
                StartCoroutine(Wait());
            }

        }
    }

    IEnumerator Wait()
    {
        waitActive = true;
        Debug.Log("This sucks");
        yield return new WaitForSeconds(1.0f);
        FindObjectOfType<GameManager>().GameOver();
    }

}
