
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManagerr gameManager;
    private void OnTriggerEnter()
    {
        
        gameManager.CompleteLevel();
    }
}
