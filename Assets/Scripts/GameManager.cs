using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static int CurrentScore;
    public static int HighScore;

    public static int CurrentLevel;
    public static int UnlockedLevel;

    private void Start()
    {
    }
    internal static void CompleteLevel()
    {
        SceneManager.LoadScene(++CurrentLevel);
    }
}
