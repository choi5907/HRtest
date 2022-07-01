using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public GameObject Pcol;
    public float enemySpeed = 0.007f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    private Animator animator;
    private GameObject obj;
    public AudioSource PainSound1;
    public AudioSource PainSound2;
    public AudioSource PainSound3;
    public int PainGen;
    public GameObject theFlash;

    private void Start() {
        animator = theEnemy.GetComponent<Animator>();
    }
    void Update() {
        // 플레이어를 바라보게한다.
        transform.LookAt(thePlayer.transform.position);
        if(ZombieDeath.isDead == false && attackTrigger == false){
            enemySpeed = 0.007f;
            animator.CrossFade("Z_Walk", 0.1f);
            transform.position = Vector3.MoveTowards(theEnemy.transform.position, new Vector3(thePlayer.transform.position.x, 0, thePlayer.transform.position.z), enemySpeed);
        }
        if(ZombieDeath.isDead == false && attackTrigger == true && isAttacking == false){
            animator.CrossFade("Z_Attack", 0.1f);
            StartCoroutine(InflactDamage());
        }
    }
    void OnTriggerEnter(Collider other) {
        enemySpeed = 0;
        if(other.gameObject == Pcol)
            attackTrigger = true;
        endTrigger();
    }
    
    IEnumerator endTrigger(){
        yield return new WaitForSeconds(0.1f);
    }

    void OnTriggerExit(Collider other) {
        if(other.gameObject == Pcol)
            attackTrigger = false; 
    }
    IEnumerator InflactDamage(){
        isAttacking = true;
        switch(PainGen){
            case 1 : PainSound1.Play();
            break;
            case 2 : PainSound2.Play();
            break;
            case 3 : PainSound3.Play();
            break;
        }
        theFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        theFlash.SetActive(false);
        yield return new WaitForSeconds(1.25f);
        GlobalHealth.currentHealt -= 5;
        PainGen = Random.Range(1, 4);
        yield return new WaitForSeconds(0.75f);
        isAttacking = false;
    }
}
