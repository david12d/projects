using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStart : MonoBehaviour
{
    public Transform player;
    public GameManager gameManager;
    Collision collisionInfo;
    

    
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Debug.Log("StartTrigger");
            gameManager.LevelStart();
        }
    }

}
