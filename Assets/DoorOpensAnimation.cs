using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpensAnimation : MonoBehaviour
{
    Animator myAnimator;

    const String  PRESS_ANIM = "DoorOpens";
    //const String  RED_ANIM = "red";
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space)){
            myAnimator.SetTrigger(RED_ANIM);
        }*/
    }

    private void OnMouseDown(){
        myAnimator.SetTrigger(PRESS_ANIM);
    }
}

