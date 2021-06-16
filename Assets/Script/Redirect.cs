using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Redirect : MonoBehaviour
{
    //界面出现判断
    public bool flag = false;
    //界面组件
    public GameObject panel;


    public void returnToEasy()
    {//跳转至简单模式场景
        SceneManager.LoadScene(0);
        playerControl.Hp = 1;
		playerControl.score = 0;
		playerControl.count1 = 0;
		playerControl.count2 = 0;
		playerControl.count3 = 0;
    }
    public void returnToDiff()
    {//跳转至困难模式场景
        SceneManager.LoadScene(2);
        playerControl.Hp = 1;
		playerControl.score = 0;
		playerControl.count1 = 0;
		playerControl.count2 = 0;
		playerControl.count3 = 0;
    }
    public void returnToMain()
    {
        //跳转至主页场景
        SceneManager.LoadScene(1);
    }

    // public void returnTo()
    // {//跳转至排行榜场景
    //     SceneManager.LoadScene(2);
    // }

    public void details(){
        panel.active = true;
        flag = true;
    }

    public void off(){
        panel.active = false;
        flag = false;
    }
}

