using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float pedalSpeed = 5f;  // Change from int to float
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
                yp = yp + pedalSpeed * Time.deltaTime;
            }

            if (Keyboard.current.downArrowKey.isPressed)
            {
                yp = yp - pedalSpeed * Time.deltaTime;
            }
            transform.position = new Vector3(7.5f, yp, 0);
        }
        else
        {
            if (Keyboard.current.wKey.isPressed)
            {
                yp = yp + pedalSpeed * Time.deltaTime;
            }

            if (Keyboard.current.sKey.isPressed)
            {
                yp = yp - pedalSpeed * Time.deltaTime;
            }
            transform.position = new Vector3(-7.5f, yp, 0);
        }
    }
}