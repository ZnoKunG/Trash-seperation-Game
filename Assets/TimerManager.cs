using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public float timeStart;
    [HideInInspector] public int totalScore;

    public GameObject disabledMenu;
    public GameObject enabledMenu;

    private void Awake()
    {
        Text.text = "TIME REMAINING : " + timeStart.ToString();
    }

    private void Update()
    {
        timeStart -= Time.deltaTime;
        Text.text = "TIME REMAINING : " + Mathf.Round(timeStart).ToString();
        if (timeStart <= 0)
        {
            disabledMenu.SetActive(false);
            enabledMenu.SetActive(true);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        disabledMenu.SetActive(true);
        enabledMenu.SetActive(false);
        Debug.Log("Pressed");
    }
}
