using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    private Rigidbody rb;
    private float moveSpeed;
    private float dirX, dirZ;
    
    private void Start() {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;
    }

    private void FixedUpdate() {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
