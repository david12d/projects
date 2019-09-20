using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{

    public float zDistance;
    public float minSpread;
    public float maxSpread;
    
    
    public Transform playerTransform;
    public Transform obstaclePrefab;
    public Transform obstaclePrefab2;

    float zSpread;
    float lastZPos;

    private void FixedUpdate()
    {
        // if player moves a random distance between maxSpread and minSpread, 
        // create an obstacle at random x position at zDistance in front of the player
        if (playerTransform.position.z - lastZPos >= zSpread)
        {
            float lanePos = Random.Range(-10, 10);
            float lanePos2 = Random.Range(-10, 10);
            float height = Random.Range(2, 10);

            Instantiate(obstaclePrefab, new Vector3(lanePos, 0, playerTransform.position.z + zDistance),
                Quaternion.identity);
            
                
            Instantiate(obstaclePrefab2, new Vector3
                (lanePos2, height, playerTransform.position.z + zDistance * 5), Quaternion.identity);
           
                      
            lastZPos = playerTransform.position.z;
            zSpread = Random.Range(minSpread, maxSpread);
        }

        


    }

}
