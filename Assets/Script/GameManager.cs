using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerpaddle;
    public Paddle computerpaddle;
    private int playerScore;
    private int computerScore;

    public Text PlayerScoreText;
    public Text ComputerScoreText;
    public void PlayerScores()
    {
        playerScore++;
        //Debug.Log(playerScore);
        this.PlayerScoreText.text = playerScore.ToString();
        RestartGame();
    }
    public void ComputerScore()
    {   
        computerScore++;
        //Debug.Log(computerScore);
        this.ComputerScoreText.text = computerScore.ToString();

        RestartGame();
        
    }
    private void RestartGame()
    {
        this.playerpaddle.Resetposition();
        this.computerpaddle.Resetposition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    
}
