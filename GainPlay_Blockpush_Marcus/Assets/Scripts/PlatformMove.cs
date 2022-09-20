using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    

    void Update()
    {
        transform.Translate(0, 0, Time.deltaTime *- GameManager.Instance.blockSpeed);
    }
}
