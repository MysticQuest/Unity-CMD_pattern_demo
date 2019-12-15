using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator anim;
    Command keyQ, keyE, keyW;


    void Start()
    {
        keyQ = new Jump();
        keyW = new DoNothing();
        keyE = new DoNothing();
        anim = actor.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            keyQ.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            keyW.Execute(anim);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            keyE.Execute(anim);
        }
    }
}