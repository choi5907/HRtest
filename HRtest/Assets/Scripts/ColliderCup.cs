using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCup : MonoBehaviour
{
    public AudioSource impactFX;
    private bool isGround = false;

    void OnCollisionEnter(Collision other) {
        if(other.relativeVelocity.magnitude > 1 && isGround == false){   // 충돌 시 힘의 값이 1 이상일 때
            impactFX.Play();                        // 사운드 재생
            GetComponent<ColliderCup>().enabled = false;
            isGround = true;
        }    
    }
}
