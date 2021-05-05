using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    Vector3 origin;
    private float movementCounter;
    private float idleCounter;
    private Vector3 targetBobPosition;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        HeadBob(idleCounter, 0.0f, -0.003f);
        idleCounter += Time.deltaTime;
        transform.localPosition = Vector3.Lerp(transform.localPosition, targetBobPosition, Time.deltaTime * 2);
    }

    void HeadBob(float p_z, float p_x_intensity, float p_y_intensity)
    {
        targetBobPosition = origin + new Vector3(Mathf.Cos(p_z) * p_x_intensity, Mathf.Sin(p_z * 2) * p_y_intensity, 0);
    }
}
