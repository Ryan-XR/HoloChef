using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchScreenManager : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ShowMenuAfterDelay(3f));
    }

    IEnumerator ShowMenuAfterDelay(float t)
    {

        yield return new WaitForSeconds(t);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SceneManager.UnloadSceneAsync("LaunchScreen");
    }
}
