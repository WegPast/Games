﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int nbLives;
    public Text textLives;

    private LevelManager levelManager;
    //private Paddle paddle;
    private Vector3 paddleToBallVector;

    // Use this for initialization
    void Start()
    {
        nbLives = 6;
        textLives.text = "x" + nbLives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoseAlife();
        }
    }

    public void LoseAlife()
    {

        nbLives--;
        textLives.text = "x" + nbLives.ToString();

        if (nbLives <= 0)
        {
            levelManager = GameObject.FindObjectOfType<LevelManager>();
            levelManager.LoadLevel("Loose");
        }
        else
        {
        }
    }
}
