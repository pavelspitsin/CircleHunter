using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadLineUpdater : MonoBehaviour {

    [SerializeField]
    private GameObject _progressBarObject;
    
    private ProgressBar _progressBar;

    private bool isAlreadyZero = false;
    private float _timeToDeath;
    private int _score;


    // Use this for initialization
    void Start () {
        _progressBar = _progressBarObject.GetComponent<ProgressBar>();
        _score = Game.ScoreManager.Score;
    }
	    

	// Update is called once per frame
	void Update ()
    {
        _timeToDeath = Game.CurrentDifficulty.DeadLineExpiredTime;

        if (Game.ScoreManager.Score > _score)
        {
            _score = Game.ScoreManager.Score;
            _progressBar.Value = 1;
        }

        if (_progressBar.Value > 0)
        {
            _progressBar.Value -= 1 / _timeToDeath * Time.deltaTime;
        }
        else if (!isAlreadyZero)
        {
            Game.GameOver();
            isAlreadyZero = true;
        }

    }
}
