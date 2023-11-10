using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2GroundCheck : MonoBehaviour
{
    public bool amIOnTheGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other) //when the groundcheck has a collider enter, it sets amIOnTheGround to true
    {
        amIOnTheGround = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        amIOnTheGround = false;
    }   
}
