using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCameraFollower : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 2f;

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed*Time.deltaTime);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }

}
