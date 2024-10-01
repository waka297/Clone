using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public RandomColor randomColor;
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    public Image[] hearts;
    private int lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = hearts.Length; //restart game
        foreach (Button btn in randomColor.buttons) 
        {
            btn.onClick.AddListener(() => GetScore(btn));
        }
    }

    public void AddScore(int points)
    {
        score += points;
    }

    public static int GetScore()
    {
        return score; //current score
    }

    public void GetScore(Button button)
    {
        Color buttonColor = button.GetComponent<Image>().color; //clicked button's color get

        Color targetColor = randomColor.GetColor(); //randomcolor get image color

        if (ColorUtility.ToHtmlStringRGB(buttonColor) == ColorUtility.ToHtmlStringRGB(targetColor))
        {
            score++;
            scoreText.text = "Score : " + score.ToString();
            randomColor.ColorUpdate();
            ResetTimer(); //scoreup->timerReset
        }
        else
        {
            score--;
            scoreText.text = "Score : " + score.ToString();
            LoseLife();
        }
    }

    public void DisplayFinalScore(TextMeshProUGUI finalscore)
    {
        finalscore.text = "Your Score: "+score.ToString();
    }

    public void ResetTimer()
    {
        Timer timer = FindObjectOfType<Timer>(); //find timer component
        if (timer != null)
        {
            timer.ResetTimerTime();
        }
    }

    private void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            hearts[lives].enabled = false;

            if (lives == 0)
            {
                SceneManager.LoadScene("game over");
            }
        }
    }
}
