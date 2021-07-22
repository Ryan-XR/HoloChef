using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPanIdleRotation : MonoBehaviour
{
    [SerializeField]
    private bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(0, 30 * Time.deltaTime, 0);
            if (transform.eulerAngles.y > 360) 
            {
                transform.rotation = Quaternion.identity;
            }
        } 
    }

    public void StartRotating()
    {
        Debug.Log("START");
        isRotating = true;
    }

    public void StopRotatingAndReset()
    {
        Debug.Log("STOP RESET");
        Quaternion target;

        if (transform.eulerAngles.y > 90) 
        {
            target = Quaternion.Euler(0, 270, 0);
        } 
        else 
        { 
            target = Quaternion.Euler(0, -90, 0); 
        }

        isRotating = false;

        StartCoroutine(RotateBackToZero(target, 0.2f));


        Color alphaColor = gameObject.GetComponent<Renderer>().material.color;
        alphaColor.a = 0;
        StartCoroutine(FadeOut(gameObject.GetComponent<Renderer>().material.color, 3));
    }

    public void StopRotating()
    {
        Debug.Log("STOP");
        isRotating = false;
    }

    IEnumerator RotateBackToZero(Quaternion endValue, float duration)
    {
        float time = 0;
        Quaternion startValue = transform.rotation;

        while (time < duration)
        {
            transform.rotation = Quaternion.Slerp(startValue, endValue, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.rotation = endValue;
    }

    IEnumerator FadeOut(Color alphaColor, float duration)
    {
        float time = 0;

        Debug.Log("FADE OUT");

        while (time < duration)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.Lerp(gameObject.GetComponent<Renderer>().material.color, alphaColor, duration * Time.deltaTime);
            time += Time.deltaTime;
            yield return null;
        }
    }
}
