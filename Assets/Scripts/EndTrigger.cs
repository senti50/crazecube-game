
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameManagerr gameManagerr;
    private void OnTriggerEnter()
    {
        
        gameManagerr.CompleteLevel();
    }
}
