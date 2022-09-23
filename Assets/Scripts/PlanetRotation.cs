using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public GameObject orbitPivot;
    public int fullOrbitTime;
    public int fullRotationTime;
    public TimeManager timeManager;
    public bool orbitReverse = false;
    public bool rotationReverse = false;

    private Vector3 _reverseOrbitVector;
    private Vector3 _reverseRotationVector;
    
    private void Awake()
    {
        _reverseOrbitVector = orbitReverse ? Vector3.up : Vector3.down;
        _reverseRotationVector = rotationReverse ? Vector3.up : Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        // rotate
        transform.Rotate(_reverseRotationVector,  360f * Time.deltaTime * timeManager.GetTimeMultiplier() / fullRotationTime );
        
        // orbit
        if (orbitPivot != null)
        {
            transform.RotateAround(orbitPivot.transform.position, _reverseOrbitVector, 360f * Time.deltaTime * timeManager.GetTimeMultiplier() / fullOrbitTime);
        }
        
    }
}
