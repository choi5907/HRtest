using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStalker : MonoBehaviour
{
    // Nav Mesh위의 적을 움직이게하는 트리거
    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;    // 트리거 콜라이더 off
        StalkerAI.isStalking = true;    // static변수 true
   }
}
