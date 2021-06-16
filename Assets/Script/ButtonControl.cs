using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//重新开始
	public void Restart()
    {
        SceneManager.LoadScene(0);
		playerControl.Hp = 1;
		playerControl.score = 0;
		playerControl.count1 = 0;
		playerControl.count2 = 0;
		playerControl.count3 = 0;
    }
	public void Restart2()
    {
        SceneManager.LoadScene(2);
		playerControl.Hp = 1;
		playerControl.score = 0;
		playerControl.count1 = 0;
		playerControl.count2 = 0;
		playerControl.count3 = 0;
    }
}
