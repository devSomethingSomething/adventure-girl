using UnityEngine;

public class GapController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        HandlePlayerCollision(collider2D);
    }

    private void HandlePlayerCollision(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            Destroy(collider2D.gameObject);
        }
    }
}
