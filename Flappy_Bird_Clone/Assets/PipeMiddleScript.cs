using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public AudioSource pointSFX;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        // as soon as a pipe spawns it will look through heirarchy to find an GameObject with a Logic tag,
        // then it will lookthrough the components looking for LogicScript, i f it finds that it will put
        // that in our refernce slot
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        pointSFX = GetComponent<AudioSource>(); // Find and identify pointSFX audio

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {// ensures the bird is getting the points and not the camera moving through the Object
        {
            if ( collision.gameObject.layer == 3 ) 
            logic.addScore(1); // logic refers to object script from above
            pointSFX.Play();

        }
    }
}

