using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaladScale : MonoBehaviour {
    
    void OnTriggerEnter(Collider col) {
        if(col.GetComponent<Collider>().tag == "Salad") {
            transform.localScale += new Vector3(-0.4f, -0.4f, -0.4f);
        }
    }
}
