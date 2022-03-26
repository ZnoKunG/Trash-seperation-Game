using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenenator : MonoBehaviour
{
    public GameObject[] trashs;
    public GameObject spawnPoint;
    private GameObject generatedTrash;
    private bool empty = true;

    private void Update()
    {
        if (empty)
        {
            int rand = Random.Range(0, trashs.Length);
            generatedTrash = Instantiate(trashs[rand], spawnPoint.transform.position, Quaternion.identity);
            empty = false;
        }

        if (Vector3.Distance(spawnPoint.transform.position, generatedTrash.transform.position) > 5.0f)
        {
            empty = true;
        }
    }
}

    

