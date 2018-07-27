using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _scriptsGameObject;

    private GameTime _gameTime;
    private Text _text;

    // Use this for initialization
    void Start()
    {
        _text = GetComponent<Text>();
        _gameTime = _scriptsGameObject.GetComponent<GameTime>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = _gameTime.CurrentTime;

        int minutes = (int)(time / 60);
        int seconds = (int)(time % 60);

        _text.text = string.Format("{0:d2}:{1:d2}", minutes, seconds);
    }
}
