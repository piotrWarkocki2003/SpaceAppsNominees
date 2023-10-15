using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public GameObject doorToBeRemoved;
    public GameObject initialSpawnPoint;
    public GameObject returnPoint;
    public GameObject player;


    private void Awake()
    {
        doorToBeRemoved = GameObject.Find("glass_panel_1_door");
        initialSpawnPoint = GameObject.Find("InitialSpawn");
        returnPoint = GameObject.Find("ReturnPoint");
        player = GameObject.Find("XR");
    }



    // Start is called before the first frame update
    void Start()
    {
        int lastSceneIndex = PlayerPrefs.GetInt("LastSceneIndex");
        Debug.Log("Last Scene Index: " + lastSceneIndex);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log("Current Scene Index: " + currentSceneIndex);

        if (lastSceneIndex == currentSceneIndex)// check if the build index for this scene is one less than the previous
        {
            player.transform.position = returnPoint.transform.position;
            doorToBeRemoved.SetActive(false);
        }

        else
        {
            player.transform.position = initialSpawnPoint.transform.position;
        }
    }
}
