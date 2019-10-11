using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    // ==============================VARIABLE DECALRATION======================================

    // Creating an array of Buttons to eventually control the enabling of Replay, Menu & Exit buttons
    public Button[] buttons;


    // Variables for Score display and calculations
	public Text scoreText;      
	public int score;


    // Variable storing the Game status (whether the Game is On or Over)
	public bool gameOver;


    // public AudioSource audioSource;
    public AudioSource audioSource;
    // Variable to handle Playing of the Music
    bool audio_play;

    // =======================================================================================


    // ====================FUNCTION DECLARATION BEGINS============================================

    // Start is called before the first frame update
    void Start()
    {
		gameOver = false;

		//Score is 0 at the start of the Game
		score = 0;          

		// Call the scoreUpdate function after 1second and repeat calling at intervals of 5seconds
		InvokeRepeating("scoreUpdate", 8.0f, 2f);

        // Getting AudioSource Componenet at the start in this script
        audioSource = GetComponent<AudioSource>();
        audio_play = true;
    }

    // Update is called once per frame
    void Update()
    {
		scoreText.text = "SCORE: " + score;
    }

	void scoreUpdate()
	{
		//The Score is updated each time with a value of 10 only untill the Game is Over
		if (!gameOver)
		{
			score += 10;
		}
        
	}

    //function to indicate that the Game is Over
	public void gameoverActivation()
	{
		gameOver = true;

        // Creating a button object of Class Button and looping it through the buttons array
		foreach (Button button in buttons)
		{
			button.gameObject.SetActive(true);
		}

        // Stop Scrolling when the game is over
		Time.timeScale = 0;
	}


	public void Play()
	{
		// Start scrolling when the game is played
		Time.timeScale = 1;
		Application.LoadLevel("level 1");
        //SceneManager.LoadScene("1");


	}

	public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

	public void Menu()
	{
        // Load the Menu 
        Application.LoadLevel("Game Menu");
	}


	public void Exit()
	{
		// Quit the application 
		Application.Quit();
	}


    // Function to Mute the Sound of the Game 
    public void Mute()
    {
        if (audio_play)
        {
            // Stopping Audio when Player clicks Mute Button
            audio_play = false;
            audioSource.mute = true;
        }
        else
        {
            // Playing Audio when Player clicks Mute Button again
            audio_play = true;
            audioSource.mute = false;
        }
    }
    

}


// ====================END OF SCRIPT============================================
