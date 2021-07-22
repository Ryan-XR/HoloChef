using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootController : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadSceneAsync("LaunchScreen", LoadSceneMode.Single);
    }
}
