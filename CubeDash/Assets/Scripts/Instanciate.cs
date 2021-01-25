using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciate : MonoBehaviour
{
    //reference to the preferb.Drag a preferb into this field in the inspector.
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;





    void Start()
    {

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        

    }

    public void SpawnObject()
    {

        Instantiate(spawnee, transform.position, Quaternion.identity);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }

    }


}

