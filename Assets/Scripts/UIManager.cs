using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public VoidEventChannelSO puzzleSolvedEC;
    public GameObject gameOverUI;

    void Start()
    {
        puzzleSolvedEC.OnEventRaised += ActivateGameOverUI;
    }

    void ActivateGameOverUI()
    {
        gameOverUI.SetActive(true);
    }
}
