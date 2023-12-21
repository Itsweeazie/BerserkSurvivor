using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItself : MonoBehaviour
{
    private float destroyDelayMilliseconds = 1.8f; // Délai en millisecondes
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time - startTime > destroyDelayMilliseconds)
        {
            Destroy(gameObject);
        }
    }
}
