using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private float pedalSpeed = 3f;  // Change from int to float
    private float yp;
    
    void Start()
    {
        yp = transform.position.y;
        Debug.Log("start");
    }

    void Update()
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
}