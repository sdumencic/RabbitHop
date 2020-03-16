using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCollision : MonoBehaviour {
    public RabbitControler7 movement;

    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
