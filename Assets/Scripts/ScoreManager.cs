using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public static int score=0;
    public Text inGameScore;
    public Text scoreText;
    public Text highScoreText;
    private void Start() {
        score=0;
    }
    private void Update() {
        inGameScore.text=score.ToString();
        scoreText.text=score.ToString();
        highScoreText.text=PlayerPrefs.GetInt("HighScore").ToString();
        HighScoreCheck();
    }

    void HighScoreCheck()
    {
        if(score>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",score);
        }
    }
}
