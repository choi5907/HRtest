using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKey : MonoBehaviour
{
    public float TheDistance;   // 오브젝트 간의 거리
    public GameObject ActionDisplay;    // 상호작용 키
    public GameObject ActionText;   // 상호작용 메시지
    public GameObject ExtraCross;   // 아이템 크로스
    public GameObject theKey;   // 열쇠

    private void Update() {
        // PlayerCasting의 레이캐스트 거리를 저장
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // 마우스 커서가 올라가 있을 때
    void OnMouseOver() {
        // 거리가 3 이하일 경우 Text 켜기
        if(TheDistance <= 5){
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Pick Up Key";
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }else{
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCross.SetActive(false);
        }
        // 액션 키가 눌러지고 거리가 3이하면 콜라이더와 텍스트끄고 애니메이션, 소리 실행
        if(Input.GetButtonDown("Action")){
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                theKey.SetActive(false);
                GlobalInventory.firstDoorKey = true;
        }
    }
    // 커서가 내려갈 때
    void OnMouseExit(){
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }
}
