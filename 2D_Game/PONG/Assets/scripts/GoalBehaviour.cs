using UnityEngine;
using TMPro;

public class GoalBehaviour : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public BallBehaviour ballScript;
    public string goalSide;
    public GameManager managementScript;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision) 
    {
        score++;
        scoreText.text = score.ToString();
        if (score >= 10)
        {
            managementScript.GameEnd();
        }
        
        
        if (goalSide == "left")
        {
            ballScript.ResetBall(1);
        }
        else
        {
            ballScript.ResetBall(-1);
        }
    }
    
    
}
