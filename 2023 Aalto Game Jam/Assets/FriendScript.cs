using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FriendScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] materialChoices;
    public Animator anim;
    public SkinnedMeshRenderer friend;
    void Start()
    {
        
        friend.material = materialChoices[Random.Range(0, materialChoices.Length)];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            anim.SetTrigger("Player");
        }
    }
}
