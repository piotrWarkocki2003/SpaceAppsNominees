using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject doorT;
    public GameObject doorB;
    public GameObject doorO;

    public GameObject doorT2;
    public GameObject doorB2;
    public GameObject doorO2;



    private void Start()

    {

        doorT = GameObject.FindWithTag("door");
        doorB = GameObject.FindWithTag("door");
        doorO = GameObject.FindWithTag("door");

        doorT2 = GameObject.FindWithTag("door2");
        doorB2 = GameObject.FindWithTag("door2");
        doorO2 = GameObject.FindWithTag("door2");

    }



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



        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "door")

        {
            doorT.SetActive(false);
            doorB.SetActive(false);
            doorO.SetActive(false);
        }



        if (collision.collider.tag == "door2")

        {
            doorT2.SetActive(false);
            doorB2.SetActive(false);
            doorO2.SetActive(false);
        }
    }
}
