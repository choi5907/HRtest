using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public static int currentHealt = 20;
    public int internalHealth;
    void Update()
    {
        internalHealth = currentHealt;
        if(currentHealt <= 0){
            SceneManager.LoadScene(1);
        }
    }
}
