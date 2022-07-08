using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrig1 : MonoBehaviour
{
    public GameObject sphereTrig;

    void OnTriggerEnter(){
        GetComponent<BoxCollider>().enabled = false;
        sphereTrig.SetActive(true);
        StartCoroutine(DeactiveSphere());
    }

    IEnumerator DeactiveSphere(){
        yield return new WaitForSeconds(0.5f);
        sphereTrig.SetActive(false);
    }
}
