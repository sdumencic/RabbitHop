using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    bool gameHasEnded = false;

    public float restartDelay = 1f;
    
    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
            Debug.Log("GAME OVER");
        }
    }

   void Restart() {
        SceneManager.LoadScene(0);
    }
}
