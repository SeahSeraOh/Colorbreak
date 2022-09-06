using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Colorbreak.Color color;

    MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        switch (color)
        {
            case Colorbreak.Color.YELLOW:
                meshRenderer.material = MaterialDatabase.instance.yellow;
                break;
            case Colorbreak.Color.BLUE:
                meshRenderer.material = MaterialDatabase.instance.blue;

                break;
            case Colorbreak.Color.RED:
                meshRenderer.material = MaterialDatabase.instance.red;

                break;
            case Colorbreak.Color.PURPLE:
                meshRenderer.material = MaterialDatabase.instance.purple;

                break;
            case Colorbreak.Color.PINK:
                meshRenderer.material = MaterialDatabase.instance.pink;

                break;
            case Colorbreak.Color.GREEN:
                meshRenderer.material = MaterialDatabase.instance.green;

                break;
        }
    }
}
