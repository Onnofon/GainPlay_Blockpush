using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerUp : MonoBehaviour
{
    public GameObject[] spawners;
    public GameObject powerups;

    public void Spawn()
    {
        int number = Random.Range(0, spawners.Length);
        Instantiate(powerups, spawners[number].transform.position, Quaternion.identity);
    }
}
