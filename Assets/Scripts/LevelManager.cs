using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get { return instance; } }
    public List<GameObject> levels;
    public GameObject activeLevel;
    public int levelIndex = 0;

    private static LevelManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        activeLevel = Instantiate(levels[levelIndex]);
    }

    public void NextLevel()
    {
        levelIndex++;
        Destroy(activeLevel);
        activeLevel = Instantiate(levels[levelIndex]);
    }
}
