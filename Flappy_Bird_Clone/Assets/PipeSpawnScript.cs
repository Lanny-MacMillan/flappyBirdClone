using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3; // seconds between spawn
    public float timer = 0; // start timer
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer < spawnRate)
        {

            timer += Time.deltaTime;
            // Time.deltaTime keeps things consistant across different computers framerates etc.
            //timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;

        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0 ), transform.rotation);
        // new Vector3 takes in 3 parameters (x, y, z)
        // new Random.Range takes in 2 parameters (0, 0) high, low
    }
}
