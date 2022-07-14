using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroSequencing : MonoBehaviour
{
    public GameObject Player;
    public GameObject textBox;
    public GameObject dataDisplay;
    public GameObject placeDisplay;
    public AudioSource naVoice01;
    public AudioSource naVoice02;
    public AudioSource naVoice03;
    public AudioSource naVoice04;
    public AudioSource naVoice05;
    public AudioSource barkSound;

    void Start() {
        Player.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin(){
        yield return new WaitForSeconds(0.5f);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        dataDisplay.SetActive(true);
        yield return new WaitForSeconds(2);
        placeDisplay.SetActive(false);
        dataDisplay.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "한 순간의 사고였다.";
        // naVoice0.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        Player.GetComponent<PlayerMovement>().enabled = true; 
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "목줄을 놓쳐 개를 뒤쫓게 됐지만";
        // naVoice02.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(3f);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "점점 주변에 소리가 들리지 않고";
        // naVoice03.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "스산하게 느껴지는 그 장소에";
        // naVoice04.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(0.5f);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "평소라면 잠겨있던 문이 열려있었다.";
        // naVoice05.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<TMPro.TextMeshProUGUI>().text = "";
        yield return new WaitForSeconds(0.5f);
        // thudsound.Play();
    }
}
