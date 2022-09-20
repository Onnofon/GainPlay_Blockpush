using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag == "Player")
        {
            gameManager.TurnBlocksGood();
            Destroy(this.gameObject);
        }
    }
}
