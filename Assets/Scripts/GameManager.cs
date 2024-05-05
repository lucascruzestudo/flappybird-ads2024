using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreView;
    [SerializeField] private GameObject gameOverView;

    private int _score;
    private int _highScore;

    public static GameManager Instance { get; private set; }

    public int Score
    {
        get => _score;
        set
        {
            scoreView.text = value.ToString();
            _score = value;
        }
    }

    private void Awake()
    {
        _highScore = PlayerPrefs.GetInt("highScore", 0);

    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void GameIsOver()
    {
        gameOverView.SetActive(true);
        if (_highScore < Score)
        {
            _highScore = Score;
            PlayerPrefs.SetInt("highScore", _highScore);
        }

        gameOverView.GetComponentInChildren<Text>().text = "High Score: " + _highScore;

        Time.timeScale = 0;
    }
}
