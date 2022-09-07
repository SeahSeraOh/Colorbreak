using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public static Grid instance;
    public List<Tile> tiles;

    private void Awake()
    {
        instance = this;
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
