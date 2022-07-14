using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATrig : MonoBehaviour
{
    public GameObject pCol;
    public GameObject dd;

    void OnTriggerEnter(Collider other) {
        if(other.gameObject == pCol){
            
        }
    }
}
