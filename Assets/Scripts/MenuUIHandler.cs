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

    void start()
    {
        DisplayHighScore();
    }

    public void DisplayHighScore()
    {
        string highScoreText = "Highscore: " + GameManager.Instance.highScore;
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

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif

    }

}
