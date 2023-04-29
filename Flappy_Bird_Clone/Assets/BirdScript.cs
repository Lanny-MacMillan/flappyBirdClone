using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public AudioSource flap; // identify flap sfx
    public float deadZone = -15; // sets a deadZone so when the bird goes below screen and hit -15y it will trigger game over
    public Rigidbody2D myRigidBody; // links this script to the bird gameBody
    public float flapStrength; // adds public float (integer field) to tinker with flapstrenth in the UI to save time coding
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start() // Start is called before the first frame update
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        flap = GetComponent<AudioSource>(); // Find and identify flap audio file
    }

    void Update() // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            flap.Play();
        }
        EnteredDeadZone();
    }

    private void EnteredDeadZone()
    {
        if (transform.position.y < deadZone )
        {
            logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // cause pipes are solid 2d not set to be triggers
    {
        logic.GameOver();
        birdIsAlive = false;
    }

}
