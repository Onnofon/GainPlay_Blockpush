using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPush : MonoBehaviour
{
    public Rigidbody rb;
    public bool col;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Goodblock")
        {
            col = true;
            rb.mass = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Goodblock")
        {
            col = false;
            rb.mass = 10000;
        }
    }

    private void Update()
    {
        if (col == false)
        {
           // rb.mass = 10000;
        }
    }
}
