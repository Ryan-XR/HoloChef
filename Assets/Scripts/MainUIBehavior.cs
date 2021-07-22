using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUIBehavior : MonoBehaviour
{
    private bool pinned = false;

    private string rvScript = "RadialView";
    private string shScript = "SolverHandler";

    public void TogglePin()
    {
        pinned = !pinned;

        (GetComponent(rvScript) as MonoBehaviour).enabled = !pinned;
        (GetComponent(shScript) as MonoBehaviour).enabled = !pinned;

    }
}
