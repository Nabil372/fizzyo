﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{

    public void changeScene()
    {
        SceneManager.LoadScene("Game");
    }
}
