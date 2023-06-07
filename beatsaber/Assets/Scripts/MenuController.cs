using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{
    public void StartBtn(){
        SceneManager.LoadScene("MainScene");//按下按鈕會切換到MainScene場景
    }
}
