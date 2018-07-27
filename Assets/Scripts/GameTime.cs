using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTime : MonoBehaviour {

    public float CurrentTime
    {
        get { return _time; }
    }
    
    private float _time = 0;

    // Use this for initialization
    void Start()
    {
        _time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
    }
}
