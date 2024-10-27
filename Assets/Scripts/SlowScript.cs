using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowScript : MonoBehaviour
{
    public float slowPercent = 50f;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Grandpa"))
        {
            other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed *= slowPercent / 100;
        }
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovementScript>().moveSpeed *= slowPercent / 100;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Grandpa"))
        {
            other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().speed *=  100 / slowPercent;

        }
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovementScript>().moveSpeed *= 100 / slowPercent;
        }
    }
}
