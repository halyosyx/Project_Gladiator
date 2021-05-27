using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float moveAmount;
    public float mouseX;
    public float mouseY;

    PlayerControls inputActions;

    Vector2 movementInput;

    public void OnEnable()
    {
        if (inputActions == null)
        {

        }
    }
}
