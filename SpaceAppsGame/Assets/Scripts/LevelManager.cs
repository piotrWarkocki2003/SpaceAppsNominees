
using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class LevelManager : MonoBehaviour

{

    int currentSceneIndex = 0;

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

        if (colision.tag == "nextLevel")

        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }



        if (colision.tag == "previousLevel")

        {


            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;


            PlayerPrefs.SetInt("LastSceneIndex", currentSceneIndex);

            PlayerPrefs.Save();

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

