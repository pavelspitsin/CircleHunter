using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonsActions : MonoBehaviour {
    

    public void StartGame()
    {
        Game.StartGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
