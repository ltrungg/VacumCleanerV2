using UnityEngine;
using TMPro;
using UnityEditor.Tilemaps;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField] private int winScore = 8;
    private int score = 0 ;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameWinUI;
    private bool isGameWin = false;
    void Start()
    {
        UpdateScore();
        gameWinUI.SetActive(false);
    }

    void Update()
    {
        
    }

    public void AddScore(int points)
    {
        if (isGameWin)
            return;

        score += points;
        UpdateScore();

        // Check win condition
        if (score >= winScore)
        {
            GameWin();
        }
    }
    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void GameWin()
    {
        isGameWin = true;
        score = 0;
        Time.timeScale = 0;
        gameWinUI.SetActive(true);
    }
    
    public void ReStartGame()
    {
        isGameWin = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
}
