using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPush : MonoBehaviour
{
    public Rigidbody rb;
    public bool col;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Goodblock")
        {
            col = true;
            rb.isKinematic = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Goodblock")
        {
            col = false;
        }
    }

    private void Update()
    {
        if(col == false)
        {
            rb.isKinematic = true;
        }
    }
}
