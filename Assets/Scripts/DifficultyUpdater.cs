using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyUpdater : MonoBehaviour {

    // Use this for initialization
    void Start() {
        StartCoroutine(ChangeDifficulty());
    }

    IEnumerator ChangeDifficulty()
    {
        Game.CurrentDifficulty = Difficulties.Easy;
        //Debug.Log("Easy");

        yield return new WaitForSeconds(10f);
        Game.CurrentDifficulty = Difficulties.Normal;
        //Debug.Log("Normal");

        yield return new WaitForSeconds(10f);
        Game.CurrentDifficulty = Difficulties.Hard;
        //Debug.Log("Hard");

        yield return new WaitForSeconds(15f);
        Game.CurrentDifficulty = Difficulties.VeryHard;
        //Debug.Log("VeryHard");
    }
}
