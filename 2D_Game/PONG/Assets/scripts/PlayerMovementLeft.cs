using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementLeft : MonoBehaviour
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