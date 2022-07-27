using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    public TMP_Text gameOverText;
    public PlayerMovement pPaddle;
    public AIMovement cPaddle;
    public GameObject replayBtn;

    private void Start()
    {
        replayBtn.SetActive(false);
        gameOverText.gameObject.SetActive(false);
    }

    public void ResetField()
    {
        pPaddle.ResetPosition();
        cPaddle.ResetPosition();
        ball.ResetPosition();
    }
    public void GameOver(){
        gameOverText.gameObject.SetActive(true);
        ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        replayBtn.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
