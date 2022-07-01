using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
    public static bool isDead = false;
    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    private Animator animator;
    public AudioSource JumpScareMusic;

    private void Start() {
        animator = TheEnemy.GetComponent<Animator>();
    }
    // damage값을 가져와서 체력에서 뺀다.
    void DamageZombie(int DamageAmount){
        EnemyHealth -= DamageAmount;
    }

    // 체력이 0이되면 animator 파라메터 값 변경
    void Update()
    {
        if(EnemyHealth <= 0){
            // animator.SetBool("Dead", true);
            animator.Play("Z_FallingBack");
            JumpScareMusic.Stop();
            isDead = true;
            StartCoroutine(ZDead());
        }
    }
    IEnumerator ZDead(){
        yield return new WaitForSeconds(2.5f);
        this.GetComponent<ZombieAI>().enabled = false;
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
