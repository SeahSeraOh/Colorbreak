using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public static Grid instance;
    public List<Tile> tiles;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Tile GetTile(Vector2Int pos)
    {
        foreach(Tile tile in tiles)
        {
            if(tile.position == pos)
            {
                return tile;
            }
        }
        return null;
    }
}
