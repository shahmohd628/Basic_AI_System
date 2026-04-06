using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuUI : MonoBehaviour
{
    public void PlayGame() {
        Time.timeScale = 1;
        SceneManager.LoadScene("ProjectStealth");
    }
    public void Quit() {
        Application.Quit();
    }
}
