using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    private void Update()
    {
        score.text = player.position.z.ToString("0");
    }
}

