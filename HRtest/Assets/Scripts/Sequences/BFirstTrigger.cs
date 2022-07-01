using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace UnityStandardAssets.Characters.FirstPerson{
    public class BFirstTrigger : MonoBehaviour
    {
        public GameObject ThePlayer;
        public GameObject TextBox;
        public GameObject Point;

        void OnTriggerEnter(Collider other){
            if(other.gameObject == ThePlayer){
                GetComponent<BoxCollider>().enabled = false;
                ThePlayer.GetComponent<PlayerMovement>().enabled = false;
                StartCoroutine(ScenePlayer());
            }
        }
        IEnumerator ScenePlayer(){
            TextBox.GetComponent<Text>().text = "Looks like a waepon on that table.";
            yield return new WaitForSeconds(2.5f);
            TextBox.GetComponent<Text>().text = "";
            ThePlayer.GetComponent<PlayerMovement>().enabled = true;
            Point.SetActive(true);
        }
    }
} 
