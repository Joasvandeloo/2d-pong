using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    private int ballSpeed = 5;
    private float direction;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float randomY = Random.Range(-1f, 1f);
        Vector2 directionVector = new Vector2(1f, randomY);
        directionVector.Normalize();
        rb.linearVelocity = ballSpeed * directionVector;
    }

    void Update()
    {
        
    }

    public void ResetBall(int spawnDirection)
    {
        float randomY = Random.Range(-1f, 1f);
        Vector2 directionVector = new Vector2(spawnDirection, randomY);
        directionVector.Normalize();
        rb.linearVelocity = ballSpeed * directionVector;
        transform.position = new Vector2(0, 0);
    }
}