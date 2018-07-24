using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour {

    [SerializeField]
    private GameObject _scoreManagerGameObject;   

    Text _textComponent;

    private void Awake()
    {
        _textComponent = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        _textComponent.text = Game.ScoreManager.Score.ToString();
    }
}
