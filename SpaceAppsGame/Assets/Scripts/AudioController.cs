using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource voiceAudioForThisScene;
    public AudioSource backgroundAudioForThisScene;
    bool noMoreCheck = true;

    // Start is called before the first frame update
    private void Awake()
    {
        voiceAudioForThisScene.Play();
        backgroundAudioForThisScene.Pause();
    }

    private void Update()
    {
        if (noMoreCheck == true)
        {
            if (!voiceAudioForThisScene.isPlaying)
            {
                backgroundAudioForThisScene.Play();
                noMoreCheck = false;
                enabled = false; // turn off the update function
            }
        }
    }
}
