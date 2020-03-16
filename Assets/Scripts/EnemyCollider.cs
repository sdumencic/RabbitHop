using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollider : MonoBehaviour{

    void OnTriggerEnter(Collider col) {
        if(col.GetComponent<Collider>().tag == "Pcela") {
            Invoke("Restart", 0.1f);
        }
    }

    

    void Restart () {
        ScoringSystem.theScore = 0;
        SceneManager.LoadScene(0);
    }
}
