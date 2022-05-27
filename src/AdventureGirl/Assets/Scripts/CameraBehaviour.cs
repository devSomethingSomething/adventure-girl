using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private Vector3 offset;

    private float playerY;

    private void Start()
    {
        offset = transform.position - player.position;

        playerY = player.position.y;
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, playerY, 0.0f) + offset;
    }
}
