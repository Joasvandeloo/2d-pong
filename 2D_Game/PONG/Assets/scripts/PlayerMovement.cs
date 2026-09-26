using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private int pedalSpeed = 3;
    
    void Start()
    {
        Debug.Log("start");
    }

    void Update()
    {
        if (Keyboard.current.upArrowKey.isPressed)
        {
            print("up arrow key is held down");
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            print("down arrow key is held down");
        }
    }
}