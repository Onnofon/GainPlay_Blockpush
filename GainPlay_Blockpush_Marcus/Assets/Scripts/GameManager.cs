using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] badBlocks;
    public float pickupTimer;
    public int points;
    void Start()
    {
        
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
