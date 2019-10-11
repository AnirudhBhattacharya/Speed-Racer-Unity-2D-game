using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    // Variable to handle Playing of the Music
    bool audio_play;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audio_play = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Funciton to Mute game audio
    void Mute()
    {

        if (audio_play)
        {
            //audioSource.mute = !audioSource.mute;
            // AudioListener.pause = true;
            audio_play = false;
            audioSource.mute = true;

            //audioSource.Stop();
        }
        else
        {
            // AudioListener.pause = false;
            audio_play = true;
            audioSource.mute = false;
        }
          
    }

        

   


}
