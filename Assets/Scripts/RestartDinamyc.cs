using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartDinamyc : MonoBehaviour
{
    public string SceneName;

    public void ReloadLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneName);
    }
}
