using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class door : MonoBehaviour
{
    public float interactionDistance;
    //public GameObject intText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, interactionDistance))
        {
                if (hit.collider.gameObject.tag == "door")
                {

                    GameObject doorParent = hit.collider.transform.root.gameObject;
                    Animator doorAnim = doorParent.GetComponent<Animator>();
                   // intText.SetActive(true);
                }
                else
                {
                   // intText.SetActive(false);
                }
        }
    }
}
