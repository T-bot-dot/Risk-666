using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerlook : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, MouseYInputName;
    [SerializeField] private float mouseSensitivity;

    private void Awake()
    {
        LockCursor();
    }

    
    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update();
    {
        CameraRotation();
    }

    private void CameraRotation()
    { 
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        transform.Rotate(-transform.right * mouseY);
    }
}