using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    private int playerScore;
    private int computerScore;
    public TMP_Text player;
    public TMP_Text computer;
    //public TMP_Text gameOverText;
    public PlayerMovement pPaddle;
    public AIMovement cPaddle;
    private bool gameover = false;
    //public AudioSource music;

    private void Start()
    {

    }

    public void PlayerScores()
    {
        playerScore++;
        player.text = playerScore.ToString();
        ResetField();
    }

    public void ComputerScores()
    {
        computerScore++;
        computer.text = computerScore.ToString();
        ResetField();
    }

    private void ResetField()
    {
        if(computerScore == 5 || playerScore == 5)
        {
            gameover = true;
            //gameOverText.gameObject.SetActive(true);
            ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            //music.Stop();
        }
        else
        {
            this.ball.ResetPosition();
            pPaddle.ResetPosition();
            cPaddle.ResetPosition();
            ball.AddStartingForce();
        }

    }
    private void ResetGame()
    {
        playerScore = 0;
        computerScore = 0;
        ResetField();
    }

    private void Update()
    {
        if (gameover)
        {
            if (Input.GetKey(KeyCode.R))
            {
                SceneManager.LoadScene("Pong");
            }
        }
    }
}
