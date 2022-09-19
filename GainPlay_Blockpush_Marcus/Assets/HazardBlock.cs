using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardBlock : MonoBehaviour
{
    public Material goodMat;
    public Material hazardMat;
    public float timeLeft;
    public bool turnedGood;
    // Start is called before the first frame update
     void Update()
    {
        if (turnedGood)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft > 0)
            {
                this.gameObject.GetComponent<MeshRenderer>().material = goodMat;
            }
            else
            {
                this.gameObject.GetComponent<MeshRenderer>().material = hazardMat;
                turnedGood = false;
            }
        }
    }
}

