﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	public void ReloadLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
