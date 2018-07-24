using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

    private float _value = 1;

    public float Value
    {
        get { return _value; }
        set
        {
            _value = value;
        }
    }

    private Image _foregorundImage;

    private void Awake()
    {
        // 1 - Skip parent Image component
        _foregorundImage = GetComponentsInChildren<Image>()[1];
    }
	
	// Update is called once per frame
	void Update () {
        _foregorundImage.fillAmount = Value;
    }
}
