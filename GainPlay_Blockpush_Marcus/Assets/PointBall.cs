using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointBall : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            gameManager.points = gameManager.points + 10;
            Destroy(this.gameObject);
        }
    }
}
