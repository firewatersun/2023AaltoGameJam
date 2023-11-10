using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIntensifier : MonoBehaviour
{
    public float startLightIntensity;

    public float endLightIntensity;

    public float lightIntensityAdd;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Light>().intensity = startLightIntensity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetComponent<Light>().intensity < endLightIntensity)
        {
            GetComponent<Light>().intensity += lightIntensityAdd;
        }
    }
}
