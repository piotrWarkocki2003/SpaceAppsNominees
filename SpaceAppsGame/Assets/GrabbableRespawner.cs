using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableRespawner : MonoBehaviour
{


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
        if(obj.gameObject.tag == "BoundObj")
        {
            obj.gameObject.transform.position = SpawnPoint;
        }

    }
}
