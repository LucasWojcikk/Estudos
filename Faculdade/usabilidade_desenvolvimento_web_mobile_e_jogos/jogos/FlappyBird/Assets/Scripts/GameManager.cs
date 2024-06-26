using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public enum GameStatus
{
    Start,
    Play,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameStatus status = GameStatus.Start;
    public float speed;

    public Bird bird;
    public PipesManager pipesManager;
    public Image startImage;
    public Image gameOverImage;
    public TMP_Text scoreText;
    public TMP_Text bestScoreText;
    int score = 0;

    private float gameOverTimer = 0f;
    private string bestScoreKey = "bestScore";
    private int bestScore;
    
    public void AddScore()
    {
        score++;
        UpdateScoreText();
    }


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score: {score.ToString()}";
    }

    private void Update()
    {
        switch (status)
        {
            case GameStatus.Start:
                StartUpdate();
                break;
            case GameStatus.Play:
                break;
            case GameStatus.GameOver:
                GameOverUpdate();
                break;
        }
    }

    private void Start()
    {
        gameOverImage.enabled = false;
        startImage.enabled = true;
        scoreText.enabled = false;
        
        // Serve para pegar dados armazenados em disco
        bestScore = PlayerPrefs.GetInt(bestScoreKey);
        UpdateBestScoreText();
    }

    private void StartUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }


    public void StartGame()
    {
       
        status = GameStatus.Play;
        bird.StartGame();
        startImage.enabled = false;
        scoreText.enabled = true;
        bestScoreText.enabled = false;
    }

    public void GameOver()
    {
        status = GameStatus.GameOver;
        gameOverImage.enabled = true;
        scoreText.enabled = true;
        bestScoreText.enabled = true;
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt(bestScoreKey, bestScore);
            UpdateBestScoreText();
        }

    }

    void GameOverUpdate()
    {
        gameOverTimer += Time.deltaTime;

        
        if (Input.GetMouseButtonDown(0))
        {
            if (gameOverTimer > 1.5)
            {
                Restart();
                
            }
        }
    }
    private void Restart()
    {
        status = GameStatus.Start;
        bird.Restart();
        pipesManager.Restart();
        startImage.enabled = true;
        gameOverImage.enabled = false;
        score = 0;
        UpdateScoreText();
        gameOverTimer = 0f;
        scoreText.enabled = false;
        bestScoreText.enabled = true;
    }

    private void UpdateBestScoreText()
    {
        bestScoreText.text = $"Best: {bestScore.ToString()}";
    }



}   
