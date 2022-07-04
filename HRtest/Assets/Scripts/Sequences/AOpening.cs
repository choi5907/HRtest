using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityStandardAssets.Characters.FirstPerson{
    public class AOpening : MonoBehaviour
    {
        public GameObject ThePlayer;
        public GameObject FadeScreenIn;
        public GameObject TextBox;
        public AudioSource Sigh;
        public AudioSource No;



        void Start() {
            ThePlayer.GetComponent<PlayerMovement>().enabled = false;
            StartCoroutine(ScenePlayer());
        }
        IEnumerator ScenePlayer(){
            yield return new WaitForSeconds(1.5f);
            FadeScreenIn.SetActive(false);
            TextBox.GetComponent<Text>().text = "...Where am I?";
            No.Play();
            yield return new WaitForSeconds(2f);
            TextBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(0.5f);
            TextBox.GetComponent<Text>().text = "I need to get out of here.";
            Sigh.Play();
            yield return new WaitForSeconds(1.7f);
            TextBox.GetComponent<Text>().text = "";
            ThePlayer.GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
