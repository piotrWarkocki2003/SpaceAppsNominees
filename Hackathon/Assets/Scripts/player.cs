using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]

    private LayerMask pickableLayerMask;

    [SerializeField]

    private Transform playerCameraTransform;

    [SerializeField]

    private GameObject pickUpUI;

    [SerializeField]

    [Min(1)]

    private float hiTRange = 3;

    private RaycastHit hit;

    

    private void Update()
    {
        if(hit.collider != null)
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(false);

            pickUpUI.SetActive(false);
        }

        if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out hit, hiTRange, pickableLayerMask))
        {
            hit.collider.GetComponent<Highlight>()?.ToggleHighlight(true);
            pickUpUI.SetActive(true);
        }
    }

   
}
