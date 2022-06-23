using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    public int LightMode;   // 애니메이션 개수
    public GameObject TorchLight;   // 애니메이션이 들어간 오브젝트

    void Update(){
        if(LightMode == 0){     // 초기값 0 코루틴 시작
            StartCoroutine(AnimateLight());
        }
    }
    IEnumerator AnimateLight(){
        LightMode = Random.Range(1, 4); // 1~3의 값 중 랜덤 실행
        if(LightMode == 1){
            TorchLight.GetComponent<Animation>().Play("TorchAnimation1");
        }
        if(LightMode == 2){
            TorchLight.GetComponent<Animation>().Play("TorchAnimation2");
        }
        if(LightMode == 3){
            TorchLight.GetComponent<Animation>().Play("TorchAnimation3");
        }
        yield return new WaitForSeconds(0.99f); // 1초의 대기시간 만큼 정지
        LightMode = 0;
    }
}
