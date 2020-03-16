using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomScale : MonoBehaviour {

    void OnTriggerEnter(Collider col) {
        if(col.GetComponent<Collider>().tag == "Mushroom") {
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        }
    }
}
