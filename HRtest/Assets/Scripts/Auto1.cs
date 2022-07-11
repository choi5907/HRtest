using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 오토세이브 스크립트
public class Auto1 : MonoBehaviour
{
    // PlayerPrefs를 이용한 "AutoSave" 이름으로 빌드번호 2번 씬 저장
    void Start()
    {
        PlayerPrefs.SetInt("AutoSave", 2);
    }
}
