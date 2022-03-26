using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingManager : MonoBehaviour
{
    private float radius = 2f;
    [HideInInspector] public GameObject trash;
    private TimerManager timer;
    private GameObject holder;
    [HideInInspector] public bool hasSorted = false;

    [HideInInspector] public int redScore;
    [HideInInspector] public int greenScore;
    [HideInInspector] public int yellowScore;
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    private void Awake()
    {
        holder = GameObject.FindGameObjectWithTag("HoldPoint");
        timer = GameObject.FindGameObjectWithTag("TimerManager").GetComponent<TimerManager>();
    }

    private void Update()
    {
        if (holder.transform.childCount != 0)
        {
            trash = holder.transform.GetChild(0).gameObject;
            float distance = Vector3.Distance(trash.transform.position, transform.position);
            if (distance <= radius)
            {
                if (gameObject.name == "Dangerous" && trash.CompareTag("Dangerous") && Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(trash);
                    redScore++;
                    timer.totalScore++;
                    Debug.Log("Dangerous = " + redScore);
                    hasSorted = true;
                }
                else if (gameObject.name == "Recycle" && trash.CompareTag("Recycle") && Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(trash);
                    yellowScore++;
                    timer.totalScore++;
                    Debug.Log("Recycle = " + yellowScore);
                    hasSorted = true;
                }
                else if (gameObject.name == "Organic" && trash.CompareTag("Organic") && Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(trash);
                    greenScore++;
                    timer.totalScore++;
                    Debug.Log("Organic = " + greenScore);
                    hasSorted = true;
                }
            }

        }
    }
}
