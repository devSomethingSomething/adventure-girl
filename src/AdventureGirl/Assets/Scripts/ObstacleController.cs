using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        HandlePlayerCollision(collider2D);
    }

    private void HandlePlayerCollision(Collider2D collider2D)
    {
        if (collider2D.CompareTag("Player"))
        {
            collider2D.GetComponent<PlayerController>().enabled = false;

            collider2D.attachedRigidbody.velocity = Vector2.zero;

            GameObject.FindObjectOfType<GameManager>().GameOver();
        }
    }
}
