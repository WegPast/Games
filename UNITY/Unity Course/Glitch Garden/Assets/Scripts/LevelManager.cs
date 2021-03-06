﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    [Header("Splash Screen")]
    [Tooltip("How long, in seconds, does the splash screen have to appear. If '0', then this scene is not a splash screen")]
    public float autoLoadLevel;


	public void LoadLevel(string name) {
        Time.timeScale = 1; // reseting timescal if the game was paused
        SceneManager.LoadScene(name);
	}

	public void LoadNextLevel() {
        Time.timeScale = 1; // reseting timescal if the game was paused
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitRequest() {
		Application.Quit();
		if (Application.isWebPlayer) {
			print("Can't quit a WebApplication, so bye bye :) ");
		}
	}

    public void Start() {
        if(autoLoadLevel > 0) {
            Invoke("LoadNextLevel", autoLoadLevel);
        }
    }

}
