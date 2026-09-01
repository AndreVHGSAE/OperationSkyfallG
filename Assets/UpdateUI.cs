using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateUI : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text lifesText;
    public TMP_Text TimeText;
    public int score;
    GameObject Timer;
    public GameObject gameOverPanel;

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

    public void OpenGameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
