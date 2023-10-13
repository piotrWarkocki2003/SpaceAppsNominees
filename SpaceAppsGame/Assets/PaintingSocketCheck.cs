using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingSocketCheck : MonoBehaviour
{
    public GameObject SocketAttach;
    // Start is called before the first frame update
    void Start()
    {
        SocketAttach.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider obj)
    {
        Debug.Log("Hello");
         if(obj.gameObject.name =="Sun Painting" && gameObject.name == "Sun Socket" || obj.gameObject.name =="Earth Painting" && gameObject.name == "Earth Socket"
            || obj.gameObject.name =="Moon Painting" && gameObject.name == "Moon Socket")
        {
            SocketAttach.SetActive(true);

            Debug.Log("Hello");
           
        }
        else
        {
            Debug.Log("Wrong Obj");
            
        }
    }

     public void OnTriggerExit(Collider obj)
    {
         SocketAttach.SetActive(false);
    }
}
