using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RayCastManager : MonoBehaviour
{
    public UIManager UIManager;
    private GameObject lastHit;
    void Update()
    {
        // if (Input.touchCount > 0)
        // {
        //     var touch = Input.GetTouch(0);
        //     if (touch.phase == TouchPhase.Began)
        //     {
        //         CastTheRay();
        //     }
        // }
        CastTheRay();

    }

    public void CastTheRay()
    { 
        var camTransform = gameObject.transform;
        RaycastHit hit;

        if(Physics.Raycast(camTransform.position, camTransform.forward, out hit))
        {
            GameObject thisHit = hit.collider.gameObject;

            if (thisHit != lastHit)
            {
                Debug.Log("hit: "+thisHit.name);
                UIManager.DisplayInfoForPlanet(thisHit);
                lastHit = thisHit;
            }

        }

    }
}