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

    //Head-bobbing
    public Camera _camera;
    private Vector3 _cameraOrigin;
    private float movementCounter;
    private float idleCounter;
    private Vector3 targetBobPosition;

    //Audio
    AudioSource footsteps;

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

        _cameraOrigin = _camera.transform.localPosition;

        footsteps = GetComponent<AudioSource>();
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

        //Headbob
        if(x == 0 && z == 0)
        {
            HeadBob(idleCounter, 0.1f, 0.1f);
            idleCounter += Time.deltaTime;
            _camera.transform.localPosition = Vector3.Lerp(_camera.transform.localPosition, targetBobPosition, Time.deltaTime * 2);
            
            if(footsteps.isPlaying)
                footsteps.Stop();
        }
        else
        {
            HeadBob(movementCounter, 0.6f, 0.3f);
            movementCounter += Time.deltaTime * 4.5f;
            _camera.transform.localPosition = Vector3.Lerp(_camera.transform.localPosition, targetBobPosition, Time.deltaTime * 6);

            if(!footsteps.isPlaying) 
                footsteps.Play();
        }
    }

    void HeadBob(float p_z, float p_x_intensity, float p_y_intensity)
    {
        targetBobPosition = _cameraOrigin + new Vector3(Mathf.Cos(p_z) * p_x_intensity, Mathf.Sin(p_z * 2) * p_y_intensity, 0);
    }
}
