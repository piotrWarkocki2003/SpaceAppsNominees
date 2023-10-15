using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    public AudioSource voiceAudioForThisScene;
    public AudioSource backgroundAudioForThisScene;
    bool noMoreCheck = true;
    public GameObject door;

    // Start is called before the first frame update
    private void Awake()
    {
        voiceAudioForThisScene.Play();
        backgroundAudioForThisScene.Pause();
    }

    void Start()
    {
        door = GameObject.Find("glass_panel_1_door");

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

                if(SceneManager.GetActiveScene().buildIndex == 1)
                {
                    door.SetActive(false);
                }

                if(SceneManager.GetActiveScene().buildIndex == 3)
                {
                    door.SetActive(false);
                }
            }
        }
    }
}
