using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private TimerManager timerManager;
    private TextMeshProUGUI Text;
    private void Awake()
    {
        Text = GetComponent<TextMeshProUGUI>();
        timerManager = GameObject.FindGameObjectWithTag("TimerManager").GetComponent<TimerManager>();

    }
    private void Update()
    {
        Text.text = "TOTAL SCORE : " + timerManager.totalScore.ToString();
    }
}
