using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Sahneyi ismine g�re y�kler
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Sonraki sahneye ge�i� yapar (build index'e g�re)
    public void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Sahneyi tekrar y�kler (Restart)
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Oyundan ��kar
    public void QuitGame()
    {
        Application.Quit();
    }
}
