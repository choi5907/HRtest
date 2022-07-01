using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public GameObject theAmmo;
    public GameObject ammoDisplayBox;
    public GameObject pCol;
    void OnTriggerEnter(Collider other) {
        if(other.gameObject == pCol){
            ammoDisplayBox.SetActive(true);
            GlobalAmmo.ammoCount += 7;
            gameObject.SetActive(false);
        }
    }
}
