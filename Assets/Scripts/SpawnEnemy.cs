using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public int enemyCount = 0;
    
    void Start() {
       StartCoroutine(EnemyDrop()); 
    }
    
    IEnumerator EnemyDrop() {
        while(enemyCount < 3) {            
            xPos = Random.Range(10, 40);
            zPos = Random.Range(-10, 15);
            Instantiate(Enemy, new Vector3(xPos, 2.5f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(45);
            enemyCount++;
        }
    }    
}
