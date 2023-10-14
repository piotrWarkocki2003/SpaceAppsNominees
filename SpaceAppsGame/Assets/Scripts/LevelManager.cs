using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject doorT;
    public GameObject doorB;
    private void OnTriggerEnter(Collider colision)
    {
        if (colision.tag == "level+")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (colision.tag == "level_")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (colision.tag == "door")
        {
            doorT.SetActive(false);
            doorB.SetActive(false);
        }
    }
}
