using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    // 컴포넌트 총 폭발파티클 총격음
    public GameObject TheGun;
    public ParticleSystem MuzzleFlash;
    public AudioSource GunFire;     
    public bool IsFiring;           // 총의 상태
    public float TragetDistance;    // 거리
    public int DamageAmount = 5;    // 입힐 데미지

    void Update()
    {
        // 총오브젝트 활성화 되어있고 Fire1키 눌렀으며 총알이 1개 이상일 때 격발
        if(TheGun.activeSelf==true && Input.GetButtonDown("Fire1") && GlobalAmmo.ammoCount >= 1){
            if(IsFiring == false){
                // 사격중이 아닐 때 총알 감소, 코루틴 실행
                GlobalAmmo.ammoCount -= 1;
                StartCoroutine(FiringPistol());
            }
        }
        
        IEnumerator FiringPistol(){
            // 레이캐스트 Shot에 부딪힐 오브젝트와의 거리, 정보를 저장
            RaycastHit Shot;
            IsFiring = true;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot)){
                TragetDistance = Shot.distance;
                // SendMessage( "호출할 이름", 입력 수치, 오류처리 )로 원하는 정보를 전달
                Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
            }
            // 애니메이션 실행, 파티클 실행, 사운드 실행 0.5f 뒤 사격중 끄기
            TheGun.GetComponent<Animation>().Play("PistolShot");
            MuzzleFlash.Play();
            GunFire.Play();
            yield return new WaitForSeconds(0.5f);
            IsFiring = false;
        }
    }
}
