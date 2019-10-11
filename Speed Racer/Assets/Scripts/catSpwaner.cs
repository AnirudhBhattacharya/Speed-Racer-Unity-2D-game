using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catSpwaner : MonoBehaviour
{
    public GameObject cat;
    public float maxPos = -2.2f;

    //After 1second, enemy car will get spawned
    public float delayTimer = 5f;
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

        if (GMS.countDownDone == true)
        {
            if (timer <= 0)
            {
                //Controlling the cat spawn position to be within the track width by limiting the x component of Vector
                Vector3 catPos = new Vector3(Random.Range(-3.2f, -2.2f), transform.position.y, transform.position.z);


                //Instantiating Car with the Position & Rotation of carSpawner object
                Instantiate(cat, catPos, transform.rotation);

                timer = delayTimer;
            }
        }

        /*
        if (timer <= 0)
        {
            //Controlling the cat spawn position to be within the track width by limiting the x component of Vector
            Vector3 catPos = new Vector3(Random.Range(-3.2f, -2.2f), transform.position.y, transform.position.z);


            //Instantiating Car with the Position & Rotation of carSpawner object
            Instantiate(cat, catPos, transform.rotation);

            timer = delayTimer;
        }
        */
    }
}
