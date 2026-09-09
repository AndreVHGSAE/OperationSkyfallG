using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class UpdateUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text lifesText;
    public TMP_Text TimeText;
    public TMP_Text HighScoreText;
    public int score;
    GameObject Timer;
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    public InputAction PauseInput;

    private void OnEnable()
    {
        PauseInput.Enable();
    }
    private void OnDisable()
    {
        PauseInput.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
    }

    public void AddLifes(int value)
    {
        lifesText.text = "Lifes: " + value;
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Points: " + score.ToString();

    }

    public void AddTime(float value)
    {
        int seg = (int)value;
        TimeText.text = "Time: " + seg.ToString("00"); 
    }

    public void HighScore()
    {
        HighScoreText.text = "High Score: " + PlayerPrefs.GetFloat("HighScore");
    }

    public void OpenGameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToTitleScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    public void OpenPauseMenu()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePauseMenu()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    void Update()
    {
        //PlayerPrefs.SetFloat("HighScore", score);
        if (PlayerPrefs.GetFloat("HighScore") < score) 
        {
            PlayerPrefs.SetFloat("HighScore", score);
        }
        HighScore();

        //if(PauseInput.wasPressedThisFrame)
        //{
        //    OpenPauseMenu();
        //}
    }
}
