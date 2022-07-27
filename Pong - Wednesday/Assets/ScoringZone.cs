using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ScoringZone : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;
    public GameManager gm;
    void start()
    {
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        BallMovement ball = coll.gameObject.GetComponent<BallMovement>();
        
        if(ball != null)
        {
            score++;
            scoreText.text = score.ToString();
            gm.ResetField();
            if(score > 0)
            {
                gm.GameOver();
            }
        }
    }
}
