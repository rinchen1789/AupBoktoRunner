using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollw : MonoBehaviour
{


    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset;
    public float cameraDelay;

    private Vector3 currentVelocity = Vector3.zero;

    void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position - target.forward * trailDistance;
            desiredPosition.y += heightOffset;

            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, cameraDelay);

            transform.LookAt(target.transform);
        }
    }



} 


