using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject pauseCanvas;
    public GameManager gameManager;
    public Text text;

    private void Update()
    {
        text.text = "Score " + gameManager.points.ToString();
    }

    public void PauseGame()
    {
        gameManager.playing = false;
        mainCanvas.SetActive(false);
        pauseCanvas.SetActive(true);

    }
    
    public void ResumeGame()
    {
        gameManager.playing = true;
        mainCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
