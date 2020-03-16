using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3 : MonoBehaviour {
    public GameObject Food;
    public int xPos;
    public int zPos;
    public int foodCount;
    
    void Start() {
       StartCoroutine(FoodDrop()); 
    }
    
    IEnumerator FoodDrop() {
        while(foodCount < 1000) {
            xPos = Random.Range(10, 40);
            zPos = Random.Range(-10, 15);
            Instantiate(Food, new Vector3(xPos, 5, zPos), Quaternion.identity);
            yield return new WaitForSeconds(15);
            foodCount++;
        }
    }    
}