using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private int sliderVal = 1;
    void Start()
    {
        
    }

    public int GetTimeMultiplier()
    {
        return sliderVal;
    }

    public void SliderMove(float val)
    {
        sliderVal = Mathf.RoundToInt(val);
        Debug.Log(sliderVal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
