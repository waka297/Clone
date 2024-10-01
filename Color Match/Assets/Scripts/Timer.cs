using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timerTime;
    float timerValue;

    private void Awake()
    {
        timerTime = 3f;
    }

    private void Update()
    {
        if (timerTime > 0)
        {
            timerTime -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("game over");
        }

        timerText.text = Mathf.Ceil(timerTime).ToString();
    }

    private void Start()
    {
        Update();
    }

    public void ResetTimerTime()
    {
        timerTime = 3f;
    }

}
