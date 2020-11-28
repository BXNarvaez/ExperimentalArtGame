using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController _characterController;
    PlayerControls controls;
    Vector2 move;
    public float speed = 12f;

    //Gravity
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundCheckRadius = 0.4f;
    public LayerMask groundLayer;
    public bool grounded;

    void Awake()
    {
        controls = new PlayerControls();

        controls.WalkAround.Movement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.WalkAround.Movement.canceled += ctx => move = Vector2.zero;
    }

    void OnEnable()
    {
        controls.WalkAround.Enable();
    }
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        groundCheck = transform.Find("GroundCheck");
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
        if(grounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = move.x;
        float z = move.y;

        Vector3 movement = transform.right * x + transform.forward * z;
        _characterController.Move(movement * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        _characterController.Move(velocity * Time.deltaTime);
    }
}
