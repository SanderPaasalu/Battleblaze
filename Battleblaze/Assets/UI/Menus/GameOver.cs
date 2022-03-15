using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void Onclick_Restart()
    {
        SceneManager.LoadScene("Mainscene");
        Time.timeScale = 1;
    }
}
