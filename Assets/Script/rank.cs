using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class rank : MonoBehaviour {
	 public  static List<user> users=new List<user>();
	 public static  List<user> theRank=new List<user>();
	 

	//对话框面板
	public  GameObject dhk;

	 //对话框确认按钮
	public Button  qrbtn;

	//用户输入的昵称
	public Text name;

	//存储用户的分数
	int newScore=0;

	public Button  btn;

	bool flag=false;

	//排行榜界面
	 public  GameObject rankk;

	//排行榜的文字
    public Text rankEye;

	// Use this for initialization
	void Start () {
		//监听排行榜的按钮
		btn.onClick.AddListener(show);
	}

	void show(){
        if(flag==false){
			Debug.Log("打开排行榜");
             rankEye.text="排行榜"+"\n";
             //只显示排名前六；
             int count =1;
             foreach(var item in theRank)
            {
                count=count+1;
                if(count==8){
                    break;
                }
                 rankEye.text+="昵称："+item.id+"               "+"分数："+item.score+"\n";
            }

			//排行榜显示
        	rankk.active=true;
            flag=true;
        }else{
			Debug.Log("关闭排行榜");
			//排行榜关闭
             rankk.active=false;
             flag=false;
        }
	
    }


	
	// Update is called once per frame
	void Update () {
		
	}


    //用户死亡时候调用，判断能不能上榜
    public  void died(int count){//需要传入分数
		//排行榜只显示前六名
		//所以只有分数达到了才会有上榜机会弹出对话框，否则不会弹出对话框

		//获取上榜最低分数
		int sbfs=0;//上榜分数默认为0；
		int len=theRank.Count;
		if(len>=6){
			sbfs=theRank[5].score;
		}
		Debug.Log("目前上榜分数："+sbfs);
		//判断是否可以上榜
		if(count>sbfs){
			Debug.Log("成功上榜");
			//复制分数到变量
			newScore=count;
			//弹出对话框
			dhk.active=true;
			//监听输入昵称的确认按钮
			qrbtn.onClick.AddListener(qr);
		}else{
		Debug.Log("未上榜");
		}
	}

	public void qr(){
		Debug.Log("用户输入的名称"+name.text);
		Debug.Log("用户点击确认");
		Debug.Log("写入的名称为："+name.text+"写入的分数为："+newScore);
		//加入到排行榜
		user u=new user(){id=name.text,score=newScore};
		users.Add(u);//加入到list中去
		//上榜之后都会更新排名
		theRank=users.OrderByDescending(t=>t.score).ToList();
		//关闭对话框
		dhk.active=false;
		newScore=0;//分数置为0
	}




}
