using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCircleComponent : MonoBehaviour {

    private void Awake()
    {
    }

    private void OnMouseDown()
    {
        Game.ScoreManager.AddScore();
        Destroy(this.gameObject);
    }
}
