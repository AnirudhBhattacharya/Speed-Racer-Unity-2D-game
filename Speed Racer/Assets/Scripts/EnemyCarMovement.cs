using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMovement : MonoBehaviour
{
    public float SPEED = 10f;


    // Start is called before the first frame update
    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 10) * SPEED * Time.deltaTime);       
    }
}
