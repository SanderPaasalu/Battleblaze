using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // declared what type are score and supplies
    public static int score;
    private Text scoreText;

    private void Awake()
    {
        scoreText = gameObject.GetComponent<Text>();

        score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        // scoreText = gameObject.GetComponent<Text>();
    }

     //Update is called once per frame
     void Update()
     {
         FinalScore();
     }

    public void FinalScore()
    {
        score = (int)(DeadEnemies.EnemiesKilled * 1.5f);
        

        scoreText.text = "Score: " + (score + Player.supplies);
    }
}
