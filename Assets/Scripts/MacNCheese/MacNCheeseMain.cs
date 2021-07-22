using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MacNCheeseMain : MonoBehaviour
{

    public void StartRecipe()
    {
        StartCoroutine(LoadScene("MacNCheese_step1"));
    }

    public void Cancel()
    {
        StartCoroutine(LoadScene("Menu"));
    }

    IEnumerator LoadScene(string sceneName)
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        SceneManager.UnloadSceneAsync("MacNCheeseRoot");
    }
}
