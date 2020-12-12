using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    public Vector3 spin;

    private Quaternion convertedSpin;

    private void Start()
    {
        convertedSpin = Quaternion.Euler(spin);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localRotation *= convertedSpin;
    }
}
