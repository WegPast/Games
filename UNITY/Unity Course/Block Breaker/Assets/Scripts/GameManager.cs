﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    private int nbLives;
    public Text textLives;

    private LevelManager levelManager;
    private Paddle paddle;
    private Vector3 paddleToBallVector;

    // Use this for initialization
    void Start() {
        nbLives = 6;
    }

    // Update is called once per frame
    void Update() {
        textLives.text = "x" + nbLives.ToString();
    }

    public void LoseAlife() {

        nbLives--;

        if (nbLives <= 0) {
            levelManager = GameObject.FindObjectOfType<LevelManager>();
            levelManager.LoadLevel("Loose");
        } else {
            NewBall();
        }
    }

    public void NewBall() {

        paddle = GameObject.FindObjectOfType<Paddle>();
        GameObject ball = Instantiate(Resources.Load("Ball")) as GameObject;

        ball.transform.position = new Vector2(paddle.transform.position.x, paddle.transform.position.y + 0.4f);
    }
}
