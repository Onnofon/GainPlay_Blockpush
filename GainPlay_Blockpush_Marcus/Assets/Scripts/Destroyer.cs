using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameOver gameOver;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameOver.GameOverScreen();
        }
        else
        {
            Destroy(other.gameObject);
        }

               

       
    }
}
