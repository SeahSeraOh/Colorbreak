using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialDatabase : MonoBehaviour
{
    public static MaterialDatabase instance;

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

    public Material yellow;
    public Material blue;
    public Material purple;
    public Material green;
    public Material red;
    public Material pink;
}
