using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCircleComponent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseDown()
    {
        Game.GameOver();
    }
}
