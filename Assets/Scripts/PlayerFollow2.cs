using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow2 : MonoBehaviour{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate() {
        Vector3 desiredPosition = 0.5f*target.position + offset;
        Vector3 smoothenedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothenedPosition;
    }
}
