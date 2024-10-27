using cakeslice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightScript : MonoBehaviour
{
    public Outline outline;
    public GameObject player;
    public float distance = 2f;
    // Start is called before the first frame update

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < distance)
        {
            if (!gameObject.CompareTag("Trap") || (player.GetComponent<PlayerRaycastScript>().holding && gameObject.CompareTag("Trap")))
                outline.color = 1;
        }
        else
            outline.color = 0;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //outline.color = 1;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //outline.color = 0;
        }
    }
    public void Disable()
    {
        outline.eraseRenderer = true;
    }
    public void Enable()
    {
        outline.eraseRenderer = false;
    }
}
