using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private int pedalSpeed = 1;
    private float yp;
    
    void Start()
    {
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

        transform.position = transform.position + new Vector3(0, yp, 0);
    }
}