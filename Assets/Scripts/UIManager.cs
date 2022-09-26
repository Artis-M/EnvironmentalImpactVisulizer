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
    
    private void Start()
    {
        _planetName = canvas.transform.Find("PlanetName").gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void DisplayInfoForPlanet(GameObject planet)
    {
        _planetName.text = planet.name;

    }
}
