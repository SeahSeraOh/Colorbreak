using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeByCode : MonoBehaviour
{
    KeyCode keyForward = KeyCode.W;
    KeyCode keyLeft = KeyCode.A;
    KeyCode keyBack = KeyCode.S;
    KeyCode keyRight = KeyCode.D;

    void Update()
    {
        if (Input.GetKeyDown(keyForward))
        {
            transform.parent.Translate(new Vector3(0, 0, 1));
            transform.Rotate(new Vector3(90, 0, 0), Space.World);
        }
        else if (Input.GetKeyDown(keyLeft))
        {
            transform.parent.Translate(new Vector3(-1, 0, 0));
            transform.Rotate(new Vector3(0, 0, 90), Space.World);
        }
        else if (Input.GetKeyDown(keyRight))
        {
            transform.parent.Translate(new Vector3(1, 0, 0));
            transform.Rotate(new Vector3(0, 0, -90), Space.World);
        }
        else if (Input.GetKeyDown(keyBack))
        {
            transform.parent.Translate(new Vector3(0, 0, -1));
            transform.Rotate(new Vector3(-90, 0, 0), Space.World);
        }
    }
}
