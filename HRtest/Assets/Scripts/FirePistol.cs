using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject TheGun;
    public ParticleSystem MuzzleFlash;
    public AudioSource GunFire;
    public bool IsFiring; 

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            if(IsFiring == false){
                StartCoroutine(FiringPistol());
            }
        }
        
        IEnumerator FiringPistol(){
            IsFiring = true;
            TheGun.GetComponent<Animation>().Play("PistolShot");
            MuzzleFlash.Play();
            GunFire.Play();
            yield return new WaitForSeconds(0.5f);
            IsFiring = false;
        }
    }
}
