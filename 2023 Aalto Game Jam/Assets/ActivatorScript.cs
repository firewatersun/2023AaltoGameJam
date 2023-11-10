using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ActivatorScript : MonoBehaviour
{

    public GameObject[] thingsToActivate;
    public GameObject[] thingsToDeactivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GameObject().tag == "Player")
        {
            foreach (var VARIABLE in thingsToActivate)
            {
                VARIABLE.SetActive(true);
            }
            foreach (var VARIABLE in thingsToDeactivate)
            {
                VARIABLE.SetActive(false);
            }
            Destroy(gameObject);
        }
        
    }
}
