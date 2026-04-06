using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour {

	public GameObject gameLoseUI;
	public GameObject gameWinUI;
	bool gameIsOver;

    [System.Obsolete]
    void Start () {
		Guard.OnGuardHasSpottedPlayer += ShowGameLoseUI;
		FindObjectOfType<Player> ().OnReachedEndOfLevel += ShowGameWinUI;
	}

    [System.Obsolete]
    void ShowGameWinUI() {
		OnGameOver (gameWinUI);
	}

    [System.Obsolete]
    void ShowGameLoseUI() {
		OnGameOver (gameLoseUI);
	}

    [System.Obsolete]
    void OnGameOver(GameObject gameOverUI) {
        Time.timeScale = 0;
		gameOverUI.SetActive (true);
		gameIsOver = true;
		Guard.OnGuardHasSpottedPlayer -= ShowGameLoseUI;
		FindObjectOfType<Player> ().OnReachedEndOfLevel -= ShowGameWinUI;
	}

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene("ProjectStealth");
    }
    public void Quit() {
        Application.Quit();
    }
    public void MainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}