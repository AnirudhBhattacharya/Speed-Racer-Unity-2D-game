using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    // =========================VARIABLE DECLRATIONS===================================================

	public float carSpeed;
    public float maxPos = 2.2f;
    Vector3 position;

    // Creating UiManager script's object inorder to access its functions
	public UiManager ui;


	// ================================================================================================


	// =========================FUNCTION DECLARATIONS==================================================


	void Start()
    {
		// Temporary variable used to just increment the value
		position = transform.position;


    }

    // Update is called once per frame
    void Update()
    {
		// Car movement is done
		//by updating the x component of position vector with user directional input
		position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;    

        transform.position = position;

		// Restricts the position of car on X axis within the limits of "-2" to "2"
		position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);                       
    }


    /*
    * Game Over Condition
    * Fucntion to destroy the Player Car when it collides with enemy car
    */
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);

            // Indicating Game Over by accessing function from UiManager script
			ui.gameoverActivation();

        }
    }

	// ================================================================================================


}
