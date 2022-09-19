using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime *- speed);
    }
}
