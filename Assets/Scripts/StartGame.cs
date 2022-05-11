using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameUI : MonoBehaviour
{
    public void StartGame(){ 
        Debug.Log ("Game Has Started");
        SceneManager.LoadScene("Theseus");
            
    }
}