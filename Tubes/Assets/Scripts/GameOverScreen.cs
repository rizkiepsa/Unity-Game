using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameOverScreen : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverPanel;


    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;

    }

    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
