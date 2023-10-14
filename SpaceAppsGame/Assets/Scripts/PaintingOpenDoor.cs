using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingOpenDoor : MonoBehaviour
{

     public GameObject door;

     public GameObject attachSunSocket;

    public GameObject attachEarthSocket;

    public GameObject attachMoonSocket;
    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
         if(attachEarthSocket.activeSelf && attachSunSocket.activeSelf && attachMoonSocket.activeSelf)
       {
            StartCoroutine(doorCoolDown(2f));
       }
       else
       {
        door.SetActive(true);
       }
    }

    IEnumerator doorCoolDown(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        door.SetActive(false);
    }
}
