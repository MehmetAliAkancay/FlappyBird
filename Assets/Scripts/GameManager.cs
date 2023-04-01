using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverCanvas;
    [SerializeField] GameObject scoreCanvas;
    private void Start() {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    #region public methods
    public void GameOver(){
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }
    public void RestartGame(){
        SceneManager.LoadScene(0);
    }
    #endregion
}
