using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotPanBehavior : MonoBehaviour
{
    public bool isPlaced = false;

    PotPanIdleRotation idleRotationScript;

    void Start()
    {
        idleRotationScript = gameObject.GetComponent<PotPanIdleRotation>();
    }

    public void PlaceItem()
    {
        isPlaced = true;
        idleRotationScript.StopRotating();
        idleRotationScript.enabled = false;

        transform.SetParent(null);
    }
}
