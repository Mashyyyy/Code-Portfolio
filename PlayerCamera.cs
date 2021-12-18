using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform target;

    [SerializeField]
    private float _smoothSpeed = 0.125f;
    [SerializeField]
    private Vector3 _offset;

    [SerializeField]
    private float 
        leftLimit, 
        rightLimit, 
        bottomLimit, 
        topLimit;

    bool isActivated = false;

    private Camera pCamera;
    private void Start()
    {
        pCamera = GetComponent<Camera>();
    }


    private void FixedUpdate()
    {
        Vector3 desiredPos = target.position + _offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, _smoothSpeed);
        transform.position = smoothedPos;

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, leftLimit, rightLimit),
            Mathf.Clamp(transform.position.y, topLimit, bottomLimit),
            transform.position.z);
    }

    public void revealHidden()
    {
        if (!isActivated)
        {
            pCamera.cullingMask = -1;
            isActivated = true;
        }
        else
        {
            pCamera.cullingMask = 1;
            isActivated = false;
        }
    }
}