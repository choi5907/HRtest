using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 총알 획득 스크립트
public class AmmoPickUp : MonoBehaviour
{   
    // 총알 총알개수 플레이어콜라이더
    public GameObject theAmmo;
    public GameObject ammoDisplayBox;
    public GameObject pCol;
    // 총알 박스가 플레이어 콜라이더와 충돌 시 총알개수 켜지고 7개, 총알 끄기
    void OnTriggerEnter(Collider other) {
        if(other.gameObject == pCol){
            ammoDisplayBox.SetActive(true);
            GlobalAmmo.ammoCount += 7;
            gameObject.SetActive(false);
        }
    }
}
