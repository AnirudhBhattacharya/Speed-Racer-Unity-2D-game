using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy the enemy car after it goes out of the game scene in order to enhance performance of game
        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(collision.gameObject);
        }
    }



}
