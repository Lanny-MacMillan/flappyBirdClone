using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody; // links this script to the bird gameBody
    public float flapStrength; // adds public float (integer field) to tinker with flapstrenth in the UI to save time coding

    
    void Start() // Start is called before the first frame update
    {
        gameObject.name = "Bad Bitch Bird";
    }

    void Update() // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
    }
}
