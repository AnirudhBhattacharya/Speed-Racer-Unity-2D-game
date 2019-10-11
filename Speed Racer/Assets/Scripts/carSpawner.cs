using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
	// Creating an array of GameObjects for multiple cars
	public GameObject[] cars;              
    int CarNo;

    public float maxPos = 2.2f;

	//After 1second, enemy car will get spawned
	public float delayTimer = 1f;         
    float timer;


    private GameManager GMS;


    // Start is called before the first frame update
    void Start()
    {
		//Initial value of timer loaded
		timer = delayTimer;
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        // Once Countdown is completed then invoke this functionality
        if (GMS.countDownDone == true)
        {
            if (timer <= 0)
            {
                //Controlling the car spawn position to be within the track width by limiting the x component of Vector
                Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);

                // Random Car generation before instantiating it in the game window
                CarNo = Random.Range(0, 6);


                //Instantiating Car with the Position & Rotation of carSpawner object
                Instantiate(cars[CarNo], carPos, transform.rotation);

                timer = delayTimer;
            }
        }

    }
}
