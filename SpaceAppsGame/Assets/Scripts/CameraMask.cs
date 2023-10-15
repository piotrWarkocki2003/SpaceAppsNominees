using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CameraMask : MonoBehaviour
{
    public Camera myCamera;
    public LayerMask cullingMask;
    public LayerMask viewerMask;
    public ActionBasedContinuousMoveProvider MoveProvider;
    public float copySpeed = 2.5f;
    public float FlySpeed = 10;
    public GameObject ReturnBack;
    


    // Start is called before the first frame update
    void Start()
    {
        //myCamera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        ReturnBack.SetActive(true);
        myCamera.cullingMask &= ~cullingMask;
        myCamera.cullingMask |= viewerMask;
        //copySpeed = MoveProvider.moveSpeed;
        MoveProvider.moveSpeed = FlySpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        ReturnBack.SetActive(false);
        MoveProvider.moveSpeed = copySpeed;       
        myCamera.cullingMask &= ~viewerMask;
        myCamera.cullingMask |= cullingMask;
    }
}
