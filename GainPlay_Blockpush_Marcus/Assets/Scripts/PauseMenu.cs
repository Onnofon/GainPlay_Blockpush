using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject pauseCanvas;

    public void PauseGame()
    {
        mainCanvas.SetActive(false);
        pauseCanvas.SetActive(true);

    }
    
    public void ResumeGame()
    {
        mainCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }
}
