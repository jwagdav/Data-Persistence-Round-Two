using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public int highScore;

    private string playerName;

    void Awake()
    {

        if (GameManager.Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

}

[System.Serializable]
public class SaveData
{
    int highScore;

    string playerName;
}

