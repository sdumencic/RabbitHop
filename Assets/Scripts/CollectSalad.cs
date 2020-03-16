using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSalad : MonoBehaviour {
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Pcela") {
           ScoringSystem.theScore += 0;
        } else {
            collectSound.Play();
            ScoringSystem.theScore += 50;
            Destroy(gameObject); 
        }             
    }  
}
