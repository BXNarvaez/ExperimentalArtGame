using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookAround : MonoBehaviour
{
    PlayerControls controls;
    Vector2 move;
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    void Awake()
    {
        controls = new PlayerControls();
        controls.LookAround.Rotation.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.LookAround.Rotation.canceled += ctx => move = Vector2.zero;    
    }

    void OnEnable()
    {
        controls.LookAround.Enable();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerBody = transform.parent;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = move.x * mouseSensitivity * Time.deltaTime;
        float mouseY = move.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 45f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
