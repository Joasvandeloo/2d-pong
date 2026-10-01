using UnityEngine;
using UnityEngine.InputSystem;

public class BallBehaviour : MonoBehaviour
{
    private int ballSpeed = 8;
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
        if (rb.linearVelocity.x < 0)
        {
            if (rb.linearVelocity.x > -5)
            {
                rb.AddForce(new Vector2(-1f, 0), ForceMode2D.Impulse);
            }
        }
        else if (rb.linearVelocity.x < 5)
        {
            rb.AddForce(new Vector2(1f, 0), ForceMode2D.Impulse);
        }
    }

    public void ResetBall(int spawnDirection)
    {
        float randomY = Random.Range(-1f, 1f);
        Vector2 directionVector = new Vector2(spawnDirection, randomY);
        directionVector.Normalize();
        rb.linearVelocity = ballSpeed * directionVector;
        transform.position = new Vector2(0, 0);
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "PlayerRight")
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                rb.AddForce(new Vector2(0, 2f), ForceMode2D.Impulse);
            }
        
            if (Keyboard.current.downArrowKey.isPressed)
            {
                rb.AddForce(new Vector2(0, -2f), ForceMode2D.Impulse);
            }
        }
        else if (col.gameObject.name == "PlayerLeft")
        {
            if (Keyboard.current.wKey.isPressed)
            {
                Debug.Log("should add force");
                rb.AddForce(new Vector2(0, 2f), ForceMode2D.Impulse);
            }
        
            if (Keyboard.current.sKey.isPressed)
            {
                rb.AddForce(new Vector2(0, -2f), ForceMode2D.Impulse);
            }
        }
    }
}