using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeLimit : MonoBehaviour
{
    public float startingTime;
    public TextMeshProUGUI countDownText;
    public GameObject gameOverPanel;

    float currentTime = 0f;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        countDownText.text = "Remaining Time: " + currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Seah_Game_ColorBreak");
    }
}
