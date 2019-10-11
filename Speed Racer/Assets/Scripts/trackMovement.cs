using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackMovement : MonoBehaviour
{
    public float speed;
    Vector2 offset;

    // GameManager Script object for handling countdown check
    private GameManager GMS;

    // UiManager Script object
    public UiManager ui;

    // Start is called before the first frame update
    void Start()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (GMS.countDownDone == true)
        {
            /*
             * INFINITE SCROLLING
             */

            //Depending on passing time & speed the offset will control the track movement
            offset = new Vector2(0, Time.time * 1f * speed);

            // Get renderer to access the material getting the mainTextureOffset & assign it the offset value.
            GetComponent<Renderer>().material.mainTextureOffset = offset;


            // Logic to Increase the Track pace as and when time passes based on increasing score
            if (ui.score > 20)
            {
                speed += 1f;
            }
            else if (ui.score > 50)
            {
                speed += 1f;
            }
            else if (ui.score > 80)
            {
                speed += 1f;
            }
            else if (ui.score > 120)
            {
                speed += 1f;
            }
            else if (ui.score > 150)
            {
                speed += 1f;
            }
            else if (ui.score > 200)
            {
                speed += 1f;
            }
            else if (ui.score > 250)
            {
                speed += 1f;
            }

            // Stop the Track scrolling when the game is over
            if (ui.gameOver == true)
            {
                speed = 0;
            }

        }

    }
}
