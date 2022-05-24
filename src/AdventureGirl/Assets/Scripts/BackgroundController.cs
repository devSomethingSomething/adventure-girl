using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    private float backgroundSpeed = 1.0f;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        UpdateBackground();
    }

    private void UpdateBackground()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0.0f);
    }
}
