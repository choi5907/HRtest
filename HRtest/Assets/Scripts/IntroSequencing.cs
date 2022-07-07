using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequencing : MonoBehaviour
{
    public GameObject textBox;
    public GameObject dataDisplay;
    public GameObject placeDisplay;
    public AudioSource naVoice01;
    public AudioSource naVoice02;
    public AudioSource naVoice03;
    public AudioSource naVoice04;
    public AudioSource naVoice05;
    public AudioSource ThudSound;
    public GameObject AllBlack;
    public GameObject loadText;

    void Start() {
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
        textBox.GetComponent<Text>().text = "The night of October 29th changed me forever.";
        // naVoice0.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = ""; 
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "I headed out to investigate hauting sounds in the woods.";
        // naVoice02.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3f);
        textBox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance";
        // naVoice03.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "I could hear those sounds again coming from there";
        // naVoice04.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5f);
        textBox.GetComponent<Text>().text = "Little did I know that this was only the begining.";
        // naVoice05.Play();
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(0.5f);
        AllBlack.SetActive(true);
        // thudsound.Play();
        yield return new WaitForSeconds(1);
        loadText.SetActive(true);
        SceneManager.LoadScene(2);

    }
}
