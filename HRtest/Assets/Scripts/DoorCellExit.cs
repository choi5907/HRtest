using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// 문 클릭 시 Scene 넘기는 스크립트
public class DoorCellExit : MonoBehaviour
{
    // 거리저장변수 상호작용버튼 상호작용텍스트 오브젝트체크 페이드아웃
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCross;
    // public AudioSource CreakSound; 문 소리
    public GameObject fadeOut;

    private void Update() {
        // PlayerCasting의 레이캐스트 거리를 저장
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // 마우스 커서가 올라가 있을 때
    void OnMouseOver() {
        // 거리가 3 이하일 경우 Text 켜기
        if(TheDistance <= 3){
            // 상호작용텍스트 변경
            ActionText.GetComponent<Text>().text = "Open Door";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }else{  // 거리 벗어나면 끄기
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCross.SetActive(false);
        }
        // 액션 키가 눌러지고 거리가 3이하면 콜라이더와 텍스트끄고 애니메이션, 소리 실행
        if(Input.GetButtonDown("Action")){
                // TheDoor.GetComponent<Animation>().Play("DoorAnimation");
                // CreakSound.Play();
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                // 페이드아웃 실행, 코루틴 실행
                fadeOut.SetActive(true);
                StartCoroutine(FadeToExit());
        }
    }
    // 커서가 내려갈 때 끄기
    void OnMouseExit(){
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }
    
    // 코루틴 3f기다렸다가 5번 씬 열기
    IEnumerator FadeToExit(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(5);
    }
}
