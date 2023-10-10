using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class TriggerActions : MonoBehaviour
{
public GameObject eclipsePrefab;
//Choose prefab you want to manipulate

public bool trigger;

public bool delete;



    void Start()
    {
        eclipsePrefab.SetActive(false);
    }


    void Update()
    {
        if (trigger)
        {
            eclipsePrefab.SetActive(true);
            trigger = false;
        }
        if (delete)
        {
            eclipsePrefab.SetActive(false);
            delete = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        eclipsePrefab.SetActive(true);
    }

    void OnTriggerStay(Collider other)
    {

    }

    void OnTriggerExit(Collider other)
    {
        eclipsePrefab.SetActive(false);
    }
}
