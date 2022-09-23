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
            if(_arRaycastManager.Raycast(touch, _hits, TrackableType.PlaneWithinPolygon))
            {
                
            }
        }    
    }
}
