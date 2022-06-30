using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    // 컴포넌트들 가져오기
    public GameObject TheGun;
    public ParticleSystem MuzzleFlash;
    public AudioSource GunFire;     
    public bool IsFiring;           // 총의 상태
    public float TragetDistance;    // 거리
    public int DamageAmount = 5;    // 입힐 데미지

    void Update()
    {
        if(TheGun.activeSelf==true && Input.GetButtonDown("Fire1")){
            if(IsFiring == false){
                StartCoroutine(FiringPistol());
            }
        }
        
        IEnumerator FiringPistol(){
            RaycastHit Shot;
            IsFiring = true;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)){
                TragetDistance = Shot.distance;
                // 레이캐스트로 정보 전달 SendMessage( "호출할 이름", 입력 수치, 오류처리 )
                Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
            }
            TheGun.GetComponent<Animation>().Play("PistolShot");
            MuzzleFlash.Play();
            GunFire.Play();
            yield return new WaitForSeconds(0.5f);
            IsFiring = false;
        }
    }
}
