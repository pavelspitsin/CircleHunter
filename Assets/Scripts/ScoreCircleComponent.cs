using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCircleComponent : MonoBehaviour {

    private void Start()
    {
        
    }

    private void OnMouseDown()
    {
        if (!Game.OnPause)
        {
            Game.ScoreManager.AddScore();
            Destroy(this.gameObject);
        }
    }
}
