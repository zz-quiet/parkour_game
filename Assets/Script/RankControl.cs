using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//没用到
public class RankControl : MonoBehaviour {
	List<Score> scoreList = new List<Score>(); //创建list，用来存Score
	public Text oneName;
	public Text oneScore;
	public Text twoName;
	public Text twoScore;
	public Text threeName;
	public Text threeScore;
	public Text fourName;
	public Text fourScore;
	public Text fiveName;
	public Text fiveScore;
	public Text sixName;
	public Text sixScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		show();

		//排行榜名字
		oneName.text = scoreList[0].id.ToString();
		twoName.text = scoreList[1].id.ToString();
		threeName.text = scoreList[2].id.ToString();
		fourName.text = scoreList[3].id.ToString();
		fiveName.text = scoreList[4].id.ToString();
		sixName.text = scoreList[5].id.ToString();

        //排行榜分数
		oneScore.text = scoreList[0].score.ToString();
		twoScore.text = scoreList[1].score.ToString();
		threeScore.text = scoreList[2].score.ToString();
		fourScore.text = scoreList[3].score.ToString();
		fiveScore.text = scoreList[4].score.ToString();
		sixScore.text = scoreList[5].score.ToString();
	}

	//分数排序
	public void show(){
        scoreList.Sort();
	}

}
