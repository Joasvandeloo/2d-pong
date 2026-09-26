using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private int pedalSpeed = 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (Input.GetKey("w"))
            {
                Debug.Log("w was pressed");
            }

            if (Input.GetKey("down"))
            {
                print("down arrow key is held down");
            }
        }
    }
}