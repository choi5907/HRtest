using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public float Distance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    
    void Update() {
        Distance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        
        if(Distance <= 3){
            Debug.Log("On");
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            if(Input.GetButtonDown("Action")){
                this.GetComponent<BoxCollider>().enabled = false;
                // ActionDisplay.SetActive(false);
                // ActionText.SetActive(false);
            }
        }
        // if(Input.GetButtonDown("Action")){
        //     if(Distance <= 3){
        //         ActionDisplay.SetActive(false);
        //         ActionText.SetActive(false);
        //     }
        // }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
