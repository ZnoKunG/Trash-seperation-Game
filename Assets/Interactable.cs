using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public float radius = 0.5f;
    private bool isHold = false;

    private Transform holdTarget;
    private void Awake()
    {
        holdTarget = GameObject.FindGameObjectWithTag("HoldPoint").transform;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    private void Update()
    {
        float distance = Vector3.Distance(holdTarget.position, transform.position);
        if (!isHold)
        {
            if (distance <= radius && Input.GetKeyDown(KeyCode.E))
            {
                isHold = true;
                transform.parent = holdTarget;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isHold = false;
                transform.parent = null;
            }
        }
        
    }

}
