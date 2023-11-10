using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlowerScript : MonoBehaviour
{
    public Mesh[] meshChoices;

    public Material[] materialChoices;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<MeshFilter>().mesh = meshChoices[Random.Range(0,meshChoices.Length)];
        GetComponentInChildren<MeshRenderer>().material = materialChoices[Random.Range(0, materialChoices.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GameObject().tag == "Player")
        {
            GetComponentInChildren<Animator>().SetTrigger("Player");
        }
    }
}
