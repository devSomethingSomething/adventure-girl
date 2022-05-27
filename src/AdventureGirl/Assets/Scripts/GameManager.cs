using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int score;

    public static void IncreaseScore(int points)
    {
        score += points;
    }
}
