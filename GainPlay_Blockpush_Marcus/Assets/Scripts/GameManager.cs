using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingletonClass<GameManager>
{
    public GameObject[] badBlocks;
    public float pickupTimer;
    public int points;
    public float timer;
    public GameOver gameOver;
    public float blockSpeed;
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            gameOver.GameOverScreen();
        }
    }

    // Update is called once per frame
    public void TurnBlocksGood()
    {
        badBlocks = GameObject.FindGameObjectsWithTag("BadBlock");
        foreach (GameObject obj in badBlocks)
        {
            var block = obj.GetComponent<HazardBlock>();
            block.turnedGood = true;
            block.timeLeft = pickupTimer;
        }
    }
}
