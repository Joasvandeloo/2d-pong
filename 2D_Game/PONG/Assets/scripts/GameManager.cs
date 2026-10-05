using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallBehaviour ballScript;
    public GameObject gameOverScreen;
    public TMP_Text leftScoreText;
    public TMP_Text rightScoreText;
    public GoalBehaviour leftGoalBehaviour;
    public GoalBehaviour rightGoalBehaviour;
    public GameObject ball;
    public GameObject padelRight;
    public GameObject padelLeft;
    
    public void GameEnd()
    {
        gameOverScreen.SetActive(true);
        ball.SetActive(false);
        padelLeft.SetActive(false);
        padelRight.SetActive(false);
    }

    public void ResetGame()
    {
        gameOverScreen.SetActive(false);
        leftScoreText.text = "0";
        rightScoreText.text = "0";
        ballScript.ResetBall(-1);
        leftGoalBehaviour.score = 0;
        rightGoalBehaviour.score = 0;
        ball.SetActive(true);
        ballScript.ResetBall(-1);
        padelLeft.SetActive(true);
        padelRight.SetActive(true);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
