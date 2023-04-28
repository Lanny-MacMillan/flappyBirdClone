using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds; // Means we bring clouds into the arra in the inspector

    [SerializeField]
    float spawnInterval;

    [SerializeField]
    GameObject endPoint;

    Vector3 startPos;
    public GameObject cloud;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        Invoke("AttemptSpawn", spawnInterval); // attempts cloud spawn at interval set in inspector
    }

    void SpawnCloud()
    {
        int randomIndex = UnityEngine.Random.Range(0, clouds.Length);
        //GameObject cloud = Instantiate(clouds[randomIndex]);
        var cloud = (GameObject) Instantiate(clouds[randomIndex]);

        cloud.transform.position = startPos;
        Debug.Log("Spawn Cloud()");

        //float startY = UnityEngine.Random.Range(startPos.y - 1f, startPos.y + 1f);
        //cloud.transform.position = new Vector3(startPos.x, startY, startPos.z);

        //float scale = UnityEngine.Random.Range(0.8f, 1.2f);
        //cloud.transform.localScale = new Vector2(scale, scale);

        //float speed = UnityEngine.Random.Range(0.5f, 1.5f);
        //cloud.GetComponent<CloudScript>().StartFloating(speed, endPoint.transform.position.x);
    }

    void AttemptSpawn()
    {
        // middle function allows room for game checks
        SpawnCloud();
        Debug.Log("AttemptSpawn()");

        Invoke("AttemptSpawn", spawnInterval); // attempts cloud spawn at interval set in inspector
    }
}
