using UnityEngine;

public class AddScore : MonoBehaviour
{
    private int scoreAmount=10;
    private void OnTriggerEnter2D(Collider2D other) {
        ScoreManager.score+=scoreAmount;
    }
}
