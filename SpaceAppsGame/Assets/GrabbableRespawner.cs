using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableRespawner : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    public Vector3 SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider obj)
    {
        if(obj.gameObject.name == "Sun obj")
        {
            obj.gameObject.transform.position = SpawnPoint;
         //   obj.attachedRigidbody.velocity = Vector3.zero;
     //       obj.attachedRigidbody.velocit
        }

        if (obj.gameObject.name == "Earth")
        {
            obj.gameObject.transform.position = SpawnPoint;
        }

        if (obj.gameObject.name == "Moon")
        {
            obj.gameObject.transform.position = SpawnPoint;

            Debug.Log("Hello");
        }

    }
}
