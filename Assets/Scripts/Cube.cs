using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Animator cubeAnimator;
    Animator parentAnimator;

    KeyCode keyForward = KeyCode.W;
    KeyCode keyLeft = KeyCode.A;
    KeyCode keyBack = KeyCode.S;
    KeyCode keyRight = KeyCode.D;

    void Start()
    {
        cubeAnimator = GetComponent<Animator>();
        parentAnimator = transform.parent.GetComponent<Animator>(); ;
    }

    void Update()
    {
        if (Input.GetKeyDown(keyForward))
        {
            cubeAnimator.SetTrigger("forward");
            parentAnimator.SetTrigger("forward");
        }
    }
}
