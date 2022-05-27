using UnityEngine;

public class ScorerController : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collider2D)
    {
        HandlePlayerCollision(collider2D);
    }

    private void HandlePlayerCollision(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            GameManager.FindObjectOfType<GameManager>().IncreaseScore(1);
        }
    }
}
