using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeys : MonoBehaviour
{
    PlayerControlling playerController;

    private void Awake()
    {
        playerController = FindObjectOfType<PlayerControlling>();
    }
    /*
    public void OnLeftDown()
    {
        playerController.HorizontalInput(-1f);
    }
    public void OnLeftUp()
    {
        playerController.HorizontalInput(0f);
    }

    public void OnRightDown()
    {
        playerController.HorizontalInput(1f);
    }

    public void OnRightUp()
    {
        playerController.HorizontalInput(0f);
    }
    */
    public void OnJump()
    {
        playerController.JumpInput();
    }
}
