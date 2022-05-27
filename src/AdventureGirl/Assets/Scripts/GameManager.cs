using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

enum GameState
{
    Start,
    InProgress,
    End,
    Win
}

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI scoreText;

    [SerializeField]
    private TextMeshProUGUI startGameText;

    [SerializeField]
    private TextMeshProUGUI gameOverText;

    [SerializeField]
    private TextMeshProUGUI winGameText;

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

        HandleGameOver();

        HandleWinGame();
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

    public void GameOver()
    {
        gameState = GameState.End;

        scoreText.text = $"Final score: {score}";

        gameOverText.gameObject.SetActive(true);
    }

    private void HandleGameOver()
    {
        if (Input.anyKeyDown && gameState == GameState.End)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void WinGame()
    {
        gameState = GameState.Win;

        scoreText.text = $"Final score: {score}";

        winGameText.gameObject.SetActive(true);
    }

    private void HandleWinGame()
    {
        if (Input.anyKeyDown && gameState == GameState.Win)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
