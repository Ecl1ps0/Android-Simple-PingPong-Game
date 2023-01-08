using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public GameObject gameStartUI;

    int score;

    void Awake()
    {
        Instance = this;
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
