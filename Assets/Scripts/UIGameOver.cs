using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class UIGameOver : MonoBehaviour
{   
    [SerializeField] TextMeshProUGUI scoreText;
    ScoreKeeper scoreKeeper;

    [System.Obsolete]
    void Awake() 
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        //scoreText.text = scoreKeeper.GetScore().ToString();
        scoreText.text = "You Scored:\n" + scoreKeeper.GetScore();
    }

    
}
