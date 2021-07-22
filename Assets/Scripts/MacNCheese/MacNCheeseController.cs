using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacNCheeseController : MonoBehaviour
{
    private int currentStep = 0;

    public GameObject uiStepsParent;
    private GameObject[] uiSteps;

    public GameObject startButton;
    public GameObject nextButton;

    private void Start()
    {
        uiSteps = new GameObject[uiStepsParent.transform.childCount];
        int i = 0;

        foreach (Transform child in uiStepsParent.transform)
        {
            uiSteps[i] = child.gameObject;

            if (i != 0)
            {
                uiSteps[i].SetActive(false);
            }

            i++;
        }

        nextButton.SetActive(false);
    }

    public void NextStep() 
    {
        if (currentStep == 0)
        {
            startButton.SetActive(false);
            nextButton.SetActive(true);
        }

        if (currentStep < uiSteps.Length - 1) 
        {
            currentStep++;

            uiSteps[currentStep - 1].SetActive(false);
            uiSteps[currentStep].SetActive(true);
        }
    }

    public void PreviousStep()
    {
        if (currentStep > 0)
        {
            currentStep--;

            uiSteps[currentStep + 1].SetActive(false);
            uiSteps[currentStep].SetActive(true);
        }

        if (currentStep == 0)
        {
            startButton.SetActive(true);
            nextButton.SetActive(false);
        }
    }
}
