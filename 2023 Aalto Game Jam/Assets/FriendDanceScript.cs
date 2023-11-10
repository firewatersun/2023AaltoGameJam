using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendDanceScript : MonoBehaviour
{
    public int numberofAnimationStates;
    private int animatorInt;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        animatorInt = Random.Range(0, numberofAnimationStates);
       anim.SetInteger("playnumber", animatorInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
