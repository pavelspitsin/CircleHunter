using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[RequireComponent(typeof(SpriteRenderer))]
public class FadeCircleComponent : MonoBehaviour {
        

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }

    
    public void Fade(float timeToInvisible)
    { 
        StartCoroutine(FadeCoroutine(timeToInvisible));
    }
    
    IEnumerator FadeCoroutine(float timeToInvisible)
    {
        Color color = _spriteRenderer.color;

        float time = 0;

        while (color.a > 0)
        {
            color.a = Mathf.Lerp(1, 0, time);
            _spriteRenderer.color = color;

            time += Time.deltaTime / timeToInvisible;

            yield return null;
        }

        Destroy(this.gameObject);
    }
}
