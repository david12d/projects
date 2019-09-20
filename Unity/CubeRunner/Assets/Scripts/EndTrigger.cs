
using UnityEngine;


public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
            {
                gameManager.CompleteLevel();
            }
                
    }
}

