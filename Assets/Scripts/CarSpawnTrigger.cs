using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnTrigger : MonoBehaviour
{
    public CarSpawnerScript spawner;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grandpa"))
        {
        Debug.Log("Car spawner activated");
        spawner.active = true;
        }
    }
}