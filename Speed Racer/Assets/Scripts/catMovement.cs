using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catMovement : MonoBehaviour
{

    public float SPEED = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Cat movement on X axis
        transform.Translate(new Vector3(10, 0) * SPEED * Time.deltaTime);
    }
}
