using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSide : MonoBehaviour
{
    public Colorbreak.Color color;
    public MaterialDatabase database;
    public VoidEventChannelSO puzzleSolvedEC;

    private Cube cube;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        cube = FindObjectOfType<Cube>();
        SetColor();
    }

    private void OnValidate()
    {
        SetColor();
    }

    void SetColor()
    {
        meshRenderer = transform.parent.GetComponent<MeshRenderer>();

        switch (color)
        {
            case Colorbreak.Color.YELLOW:
                meshRenderer.material = database.yellow;

                break;
            case Colorbreak.Color.BLUE:
                meshRenderer.material = database.blue;

                break;
            case Colorbreak.Color.RED:
                meshRenderer.material = database.red;

                break;
            case Colorbreak.Color.PURPLE:
                meshRenderer.material = database.purple;

                break;
            case Colorbreak.Color.PINK:
                meshRenderer.material = database.pink;

                break;
            case Colorbreak.Color.GREEN:
                meshRenderer.material = database.green;

                break;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Wall wall = other.GetComponent<Wall>();
        if (wall != null)
        {
            Colorbreak.Color wallColor = wall.color;
            if(wallColor == color)
            {
                puzzleSolvedEC.RaiseEvent();
                cube.canMove = false;
            }
        }
    }
}
