using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUiController : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverPanel;

    [SerializeField]
    private GameObject _topUiPanel;

    private CanvasGroup _topPanelCanvas;

    private void Awake()
    {
        _topPanelCanvas = _topUiPanel.GetComponent<CanvasGroup>();
        Game.GameOverEvent += GameOver;
    }

    private void OnDestroy()
    {
        Game.GameOverEvent -= GameOver;
    }



    #region Public Actions

    public void Pause()
    {
        Game.PauseOn();
    }

    public void Resume ()
    {
        Game.PauseOff();
    }
	
	public void Leave ()
    {
        Game.PauseOff();
        Game.StopGame();
    }

    public void TryAgain()
    {
        Game.PauseOff();
        Game.StartGame();
    }



    public void TopPanelInactivate()
    {
        _topPanelCanvas.interactable = false;
        //_topPanelCanvas.alpha = 0.5f;
    }

    public void TopPanelActive()
    {
        _topPanelCanvas.interactable = true;
        //_topPanelCanvas.alpha = 1f;
    }

    #endregion
    


    private void GameOver()
    {
        Game.PauseOn();
        DisplayGameOverPanel();
        TopPanelInactivate();
    }

    private void DisplayGameOverPanel()
    {
        if (_gameOverPanel != null)
            _gameOverPanel.SetActive(true);
    }
    
}
