using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int score;

    public void IncreaseScore(int points)
    {
        score += points;

        scoreText.text = $"Score: {score}";
    }
}
