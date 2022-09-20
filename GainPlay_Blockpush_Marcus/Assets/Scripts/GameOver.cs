using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameManager gameManager;
    public Text text;

    public void GameOverScreen()
    {
        Time.timeScale = 0;
        text.text = "Score " + gameManager.points.ToString();
        mainCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
        gameManager.Save();
    }
}
