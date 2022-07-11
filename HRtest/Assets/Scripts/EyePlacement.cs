using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 눈 두개가 모였을 때 나가는 문 여는 스크립트
public class EyePlacement : MonoBehaviour
{
    public float TheDistance;   // 오브젝트 간의 거리
    public GameObject ActionDisplay;    // 상호작용 키
    public GameObject ActionText;   // 상호작용 메시지
    public GameObject ExtraCross;   // 아이템 크로스
    public GameObject EyePiece;     // 눈 오브젝트
    public GameObject realWall;     // 열릴 문

    

    private void Update() {
        // PlayerCasting의 레이캐스트 거리를 저장
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // 마우스 커서가 올라가 있을 때
    void OnMouseOver() {
        if(GlobalInventory.leftEye == true && GlobalInventory.rightEye == true){
        // 거리가 5 이하일 경우 Text 켜기
        if(TheDistance <= 5){
            ActionDisplay.SetActive(true);
            ActionText.GetComponent<Text>().text = "Place Eye Pieces";
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }else{  // 벗어나면 끄기
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCross.SetActive(false);
        }
        // 액션키가 눌러지면 콜라이더 끄고 텍스트,크로스 끄고 눈 오브젝트 켜고 문 열리는 애니메이션 실행
        if(Input.GetButtonDown("Action")){
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                EyePiece.SetActive(true);
                realWall.GetComponent<Animator>().Play("WallAnimation");
        }
        }
    }
    // 커서가 벗어나면 끄기
    void OnMouseExit(){
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }
}
