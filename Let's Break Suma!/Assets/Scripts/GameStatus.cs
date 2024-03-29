﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class GameStatus : MonoBehaviour
{
    // configuration parameters

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;

    [SerializeField] int pointsPerBlockDestroyed = 75;

    //[SerializeField] TextMeshProUGUI scoreText;

    string scoreText;

    // State variables

    [SerializeField] int currentScore = 0;

    /*
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;

        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    */

    private void Start()
    {
        scoreText = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText = currentScore.ToString();
    }
}
