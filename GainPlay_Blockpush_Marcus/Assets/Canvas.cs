using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public GameManager gameManager;
    public Text text;

    private void Update()
    {
        text.text = "Score " + gameManager.points.ToString();
    }
}
