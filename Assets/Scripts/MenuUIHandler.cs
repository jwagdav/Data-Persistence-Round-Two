using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highScoreText;
    public int highScore = 0;

    void Start()
    {

        UpdateHighScore();
        DisplayHighScore();

    }

    public void UpdateHighScore()
    {
        if(GameManager.Instance.highScore > highScore)
        {
            highScore = GameManager.Instance.highScore;
        }
    }

    public void DisplayHighScore()
    {
        highScoreText.text = "Highscore: " + highScore;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        GameManager.Instance.SaveScore();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }

}
