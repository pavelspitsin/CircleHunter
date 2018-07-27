using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game {

    #region Delegates and Events

    public delegate void GameOverAction();
    public static event GameOverAction GameOverEvent;

    #endregion

    

    public static ScoreManager ScoreManager { get; private set; }

    public static Difficulty CurrentDifficulty { get; set; }

    public static bool OnPause { get; private set; }
    

    static Game()
    {
        ScoreManager = new ScoreManager();
        CurrentDifficulty = Difficulties.Easy;
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
        OnPause = true;
    }

    public static void PauseOff()
    {
        Time.timeScale = 1;
        OnPause = false;
    }
}
