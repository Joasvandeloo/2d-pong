using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float pedalSpeed = 12f;
    private float yp;
    public string side;
    
    void Start()
    {
        yp = transform.position.y;
        Debug.Log("start");
    }

    void Update()
    {
        if (side == "left")
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                if (transform.position.y < 5)
                {
                    yp = yp + pedalSpeed * Time.deltaTime;
                }
            }

            if (Keyboard.current.downArrowKey.isPressed)
            {
                if (transform.position.y > -5)
                {
                    yp = yp - pedalSpeed * Time.deltaTime;
                }
            }
            transform.position = new Vector3(7.5f, yp, 0);
        }
        else
        {
            if (Keyboard.current.wKey.isPressed)
            {
                if (transform.position.y < 5)
                {
                    yp = yp + pedalSpeed * Time.deltaTime;
                }
            }

            if (Keyboard.current.sKey.isPressed)
            {
                if (transform.position.y > -5)
                {
                    yp = yp - pedalSpeed * Time.deltaTime;
                }
            }
            transform.position = new Vector3(-7.5f, yp, 0);
        }
    }
}