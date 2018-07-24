using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager {

    private int _scores = 0;

    public int Score
    {
        get { return _scores; }
    }

    public void AddScore()
    {
        _scores++;
    }

    public void Reset()
    {
        _scores = 0;
    }
}
