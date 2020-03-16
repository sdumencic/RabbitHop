using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitControler7 : MonoBehaviour {
    
    CharacterController controller;
    Animator anim;

    void Start() {
        controller = GetComponent<CharacterController> ();
        anim = GetComponent<Animator> ();
    }

    void Update() {
        var moveSpeed = 10.0f;

        if(Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)){
            anim.SetInteger("condition", 1);
        } else {
            anim.SetInteger("condition", 0);
        }
        
        var x = moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
    
        var z = moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x, 0f, z, Space.World);

        float angle = Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;

        
        if(Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f){
            transform.rotation =  Quaternion.Euler(0f, angle, 0f);
        }                      
    }
}
