using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class TapManager : MonoBehaviour
{
    private ARRaycastManager _arRaycastManager;
    static List<ARRaycastHit> _hits = new List<ARRaycastHit>();
    private Vector2 _touchPosition;
    public GameObject objectToCreate;
    
    
    void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouch(out Vector2 touch)
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0).position;
            return true;
        }

        touch = default;
        return false;
    }
    void Update()
    {
        if (TryGetTouch(out Vector2 touch))
        {
            var RayCastTouch = Input.GetTouch(0);
            if(_arRaycastManager.Raycast(RayCastTouch.position, _hits, TrackableType.PlaneWithinPolygon))
            {
                /*var hitpose = _hits[0].pose;
                Instantiate(objectToCreate, hitpose.position, hitpose.rotation);*/
            }
        }    
    }
}
