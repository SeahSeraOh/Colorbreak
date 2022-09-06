using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public bool canMove = true;
    public bool blockedForward = false;
    public bool blockedBack = false;
    public bool blockedLeft = false;
    public bool blockedRight = false;

    private Vector2Int position;

    KeyCode keyForward = KeyCode.W;
    KeyCode keyLeft = KeyCode.A;
    KeyCode keyBack = KeyCode.S;
    KeyCode keyRight = KeyCode.D;

    private void Awake()
    {
        position = new Vector2Int(Mathf.RoundToInt(transform.parent.position.x), Mathf.RoundToInt(transform.parent.position.z));
    }

    void Update()
    {
        CheckSurroundings();
        Move();
    }

    private void CheckSurroundings()
    {
        blockedForward = blockedBack = blockedLeft = blockedRight = false;
        var north = Grid.instance.GetTile(new Vector2Int(position.x, position.y + 1));
        if (north.isBlocked)
        {
            blockedForward = true;
        }
        var south = Grid.instance.GetTile(new Vector2Int(position.x, position.y - 1));
        if (south.isBlocked)
        {
            blockedBack = true;
        }
        var west = Grid.instance.GetTile(new Vector2Int(position.x - 1, position.y));
        if (west.isBlocked)
        {
            blockedLeft = true;
        }
        var east = Grid.instance.GetTile(new Vector2Int(position.x + 1, position.y));
        if (east.isBlocked)
        {
            blockedRight = true;
        }
    }

    private void Move()
    {
        if (Input.GetKeyDown(keyForward) && !blockedForward)
        {
            transform.parent.Translate(new Vector3(0, 0, 1));
            transform.Rotate(new Vector3(90, 0, 0), Space.World);
        }
        else if (Input.GetKeyDown(keyLeft) && !blockedLeft)
        {
            transform.parent.Translate(new Vector3(-1, 0, 0));
            transform.Rotate(new Vector3(0, 0, 90), Space.World);
        }
        else if (Input.GetKeyDown(keyRight) && !blockedRight)
        {
            transform.parent.Translate(new Vector3(1, 0, 0));
            transform.Rotate(new Vector3(0, 0, -90), Space.World);
        }
        else if (Input.GetKeyDown(keyBack) && !blockedBack)
        {
            transform.parent.Translate(new Vector3(0, 0, -1));
            transform.Rotate(new Vector3(-90, 0, 0), Space.World);
        }
        position = new Vector2Int(Mathf.RoundToInt(transform.parent.position.x), Mathf.RoundToInt(transform.parent.position.z));
    }
}
