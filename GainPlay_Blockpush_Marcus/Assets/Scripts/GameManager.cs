using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : GenericSingletonClass<GameManager>
{
    public GameObject[] badBlocks;
    public float pickupTimer;
    public int points;
    public float timer;
    public float timePlayed;
    public GameOver gameOver;
    public float blockSpeed;
    public Saver saver;
    public bool playing;
    public SaveObject so;
    private void Update()
    {
        if (playing)
        {
            timePlayed += Time.deltaTime;
        }

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

    public void Save()
    {
        so.timePlayed = (int)timePlayed;
        so.score = points;
        so.timeCode = System.DateTime.UtcNow.ToString();
        saver.Save(so);
    }
}
