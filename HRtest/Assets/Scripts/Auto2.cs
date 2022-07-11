using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto2 : MonoBehaviour
{
    // PlayerPrefs를 이용한 "AutoSave" 이름으로 빌드번호 5번 씬 저장
    void Start()
    {
        PlayerPrefs.SetInt("AutoSave", 5);
    }
}
