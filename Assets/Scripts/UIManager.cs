using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour  
{
    public Canvas canvas;
    private TextMeshProUGUI _planetName;
    private TextMeshProUGUI _planetInfo;
    
    private void Start()
    {
        _planetName = canvas.transform.Find("PlanetName").gameObject.GetComponent<TextMeshProUGUI>();
        _planetInfo = canvas.transform.Find("PlanetInfo").gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void DisplayInfoForPlanet(GameObject planet)
    {
        _planetName.text = planet.name;

        switch (planet.name)
        {
            case "Moon": _planetInfo.text = "Info:\r\n\tDistance from Earth: 384,400 km\r\n\tOrbital period(around Earth): 27.3 d\r\n\tAverage orbital speed:  1.022 km/s\r\n\tSurface gravity: 1.622 m/s2"; break;
            case "Sun": _planetInfo.text = "Info:\r\n\tMean distance from Earth: 1 AU ≈ 1.496×108 km, 8 min 19 s at light speed\r\n\tSurface area: 6.09×1012 km2, t12,000 × Earth\r\n\tRotation velocity(at equator): t1.997 km/s"; break;
            case "Earth": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 29.78 km/s\r\n\tOrbital period: 365.256363004 d\r\n\tRotation period: 23 hours and 56 minutes\r\n\tSurface gravity: 9.80665 m/s2"; break;
            case "Venus": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 35.02 km/s\r\n\tOrbital period: 224.701 d\r\n\tRotation period: 243 d\r\n\tSurface gravity: 8.87 m/s2"; break;
            case "Mercury": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 47.36 km/s\r\n\tOrbital period: 87.9691 d\r\n\tRotates on its axis exactly three times for every two revolutions it makes around the Sun"; break;
            case "Neptune": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 5.43 km/s\r\n\tOrbital period: 164.8 yr\r\n\tRotation period: 16.11 hours\r\n\tSurface gravity: 11.15 m/s2"; break;
            case "Uranus": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 6.80 km/s\r\n\tOrbital period: 84.0205 yr\r\n\tRotation period: 17 hours, 14 minutes\r\n\tSurface gravity: 8.69 m/s2"; break;
            case "Saturn": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 9.68 km/s\r\n\tOrbital period: 29.4571 yr\r\n\tA precise value for the rotation period of the interior remains elusive.\r\n\tSurface gravity: 10.44 m/s2"; break;
            case "Jupiter": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 13.07 km/s\r\n\tOrbital period: 11.862 yr\r\n\tRotation period: 9 hours and 50 minutes\r\n\tSurface gravity: 24.79 m/s2"; break;
            case "Mars": _planetInfo.text = "Info:\r\n\tAverage orbital speed: 24.07 km/s\r\n\tOrbital period: 686.980 d\r\n\tRotation period: 24.6 hours\r\n\tSurface gravity: 3.72076 m/s2"; break;
            default: _planetInfo.text = ""; break;
        }
    }
}
