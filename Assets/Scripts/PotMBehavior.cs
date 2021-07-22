using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotMBehavior : MonoBehaviour
{

    private bool isRotating = false;

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 30 * Time.deltaTime, 0);
        }
    }

    public void StartRotating()
    {
        isRotating = true;
    }

    public void StopRotatingAndReset()
    {
        float rotation = transform.rotation.y;
    }

    public void StopRotating()
    {
        isRotating = false;
    }
}
