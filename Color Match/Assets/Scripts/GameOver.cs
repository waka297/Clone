using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI finalScoreprint;

    public void Gameover()
    {
        int finalscore = Score.GetScore();
        finalScoreprint.text = "Your Score: " + finalscore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        Gameover();
        ResetGame();
    }

    public void ResetGame()
    {
        Score.score = 0; //restart game
    }
}
