using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 컵이 충돌시 한 번 소리가 나는 스크립트
public class ColliderCup : MonoBehaviour
{
    // 사운드, bool 변수로 한 번만 실행
    public AudioSource impactFX;
    private bool isGround = false;

    void OnCollisionEnter(Collision other) {
        if(other.relativeVelocity.magnitude > 1 && isGround == false){   // 충돌 시 힘의 값이 1 이상일 때
            impactFX.Play();                        // 사운드 재생
            GetComponent<ColliderCup>().enabled = false;    // 콜라이더 끄기
            isGround = true;    // 앞으로 재생되지 않게 true로 변경
        }    
    }
}
