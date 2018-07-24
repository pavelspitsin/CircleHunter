using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game {

    public delegate void GameOverAction();
    public static event GameOverAction GameOverEvent;

    public static ScoreManager ScoreManager
    {
        get; private set;
    }

    static Game()
    {
        ScoreManager = new ScoreManager();
    }


    public static void StartGame()
    {
        ScoreManager.Reset();
        SceneManager.LoadScene("Game");
    }

    public static void StopGame()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void GameOver()
    {
        if (GameOverEvent != null)
            GameOverEvent.Invoke();
    }

    public static void PauseOn()
    {
        Time.timeScale = 0;
    }

    public static void PauseOff()
    {
        Time.timeScale = 1;
    }
}
