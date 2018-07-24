using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockUI : MonoBehaviour {

    private float _time = 0;
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
        _time = 0;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        _time += Time.deltaTime;

        int minutes = (int)(_time / 60);
        int seconds = (int)(_time % 60);

        _text.text = string.Format("{0:d2}:{1:d2}", minutes, seconds);
    }
}
