using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlanets : MonoBehaviour
{
    public GameObject planets;
    public ValuesObject gameValues;

    public void Start()
    {
        planets.SetActive(gameValues.planets);
    }
    public void Toggle()
    {
        gameValues.planets = !gameValues.planets;
        planets.SetActive(gameValues.planets);
    }
}
