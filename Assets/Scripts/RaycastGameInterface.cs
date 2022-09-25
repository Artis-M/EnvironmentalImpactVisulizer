using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RaycastGameInterface : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cursorChildObject;
    public GameObject objectToPlace;
    public ARRaycastManager raycastManager;
    List<ARRaycastHit> _hits = new List<ARRaycastHit>();
    public bool useCursor = true;
    void Start()
    {
        cursorChildObject.SetActive(useCursor);
    }

    // Update is called once per frame
    void Update()
    {
        if (useCursor)
        {
            UpdateCursor();
        }

        if (Input.touchCount <= 0) return;
        var touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;
        var RayCastTouch = Input.GetTouch(0);
        if(!raycastManager.Raycast(RayCastTouch.position, _hits, TrackableType.PlaneWithinPolygon)) return;
        var hitpose = _hits[0].pose;
        Instantiate(objectToPlace, hitpose.position, hitpose.rotation);
        
    }

    public void UpdateCursor()
    {
        Vector2 screenPos = Camera.main.ViewportToScreenPoint(new Vector2(0.5f, 0.5f));
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if(!raycastManager.Raycast(screenPos, _hits, TrackableType.PlaneWithinPolygon)) return;
        transform.position = hits[0].pose.position; 
        transform.rotation = hits[0].pose.rotation;
    }
}
