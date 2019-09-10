using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ryan mcvicker
// 9/8/2019
public class ThirdPersonCamera : MonoBehaviour
{
    public Transform LookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 4.0f;
    private float sensivityY = 1.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        //put camera on top of player, then apply rotation times direction
        camTransform.position = LookAt.position + rotation * dir;
        //points the camera at the player
        camTransform.LookAt(LookAt.position);
    }
}
