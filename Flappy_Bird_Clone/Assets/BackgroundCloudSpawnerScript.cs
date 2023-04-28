using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundCloudSpawnerScript : MonoBehaviour
{
    public GameObject clouds;
    public float spawnRate = 30; // seconds between spawn
    public float timer = 0; // start timer
    public float cloudOffset = 3;


    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {

            //timer += Time.deltaTime;
            // Time.deltaTime keeps things consistant across different computers framerates etc.
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;

        }
    }

    void spawnCloud()
    {
        float lowestPoint = transform.position.y - cloudOffset;
        float highestPoint = transform.position.y + cloudOffset;

        Instantiate(clouds, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        // new Vector3 takes in 3 parameters (x, y, z)
        // new Random.Range takes in 2 parameters (0, 0) high, low
    }
}