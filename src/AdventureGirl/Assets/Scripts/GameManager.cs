using TMPro;
using UnityEngine;

enum GameState
{
    Start,
    InProgress,
    End
}

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private TextMeshProUGUI startGameText;

    [SerializeField]
    private PlayerController playerController;

    private int score;

    private GameState gameState;

    private void Start()
    {
        gameState = GameState.Start;
    }

    public void IncreaseScore(int points)
    {
        score += points;

        scoreText.text = $"Score: {score}";
    }

    private void Update()
    {
        StartGame();
    }

    private void StartGame()
    {
        if (Input.anyKeyDown && gameState == GameState.Start)
        {
            scoreText.gameObject.SetActive(true);

            startGameText.enabled = false;

            playerController.enabled = true;

            gameState = GameState.InProgress;
        }
    }
}
