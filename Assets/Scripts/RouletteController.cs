using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ルーレットオブジェクトにはこちらのスクリプトをアタッチ
public class RouletteController : MonoBehaviour
{
    GameObject textBackGround;
    GameObject lotteryResult;
    float firstRotSpeed = 0; //１度目の回転速度変数
    float secondRotSpeed= 0; //２度目のタップでの回転速度変数



    void Start()
    {
        textBackGround = GameObject.Find("TextBackGround");
        lotteryResult = GameObject.Find("LotteryResult");
        this.textBackGround.SetActive(false);
        this.lotteryResult.SetActive(false);
    }

    void Update()
    {
        if( this.firstRotSpeed == 10.0f )
        {
            //2回目のタップで回転の減速
            if(Input.GetMouseButtonDown(0))
            {
                this.firstRotSpeed = 0;
                this.secondRotSpeed = 10.0f;
                Debug.Log("2");
            }
        }
        //タップの制限
        else if(this.firstRotSpeed == 0  && this.secondRotSpeed ==0)
        {
            //回転機能
            if(Input.GetMouseButtonDown(0))
            {
                this.firstRotSpeed = 10.0f;
                Debug.Log("1");
            }
        }

        transform.Rotate(0, 0, this.firstRotSpeed + secondRotSpeed);
        this.secondRotSpeed *= 0.98f;

        //２度目のタップで止まる時、くじ結果を表示
        if( 0 < this.secondRotSpeed )
        {
            if(this.secondRotSpeed < 0.05f  && firstRotSpeed == 0)
            {
                this.secondRotSpeed =0;

                //おみくじ機能 rouletteの角度で判断
                if(transform.localEulerAngles.z < 30.0f || 360.0f < transform.localEulerAngles.z)
                {
                    Debug.Log("凶");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n凶\nアゲてこ！！";
                }
                else if(30.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 90.0f)
                {
                    Debug.Log("大吉");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n大吉\n最高！！神！";

                }
                else if(90.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 150.0f)
                {
                    Debug.Log("大凶");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n大..\n大吉最高！！";
                }
                else if(150.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 210.0f)
                {
                    Debug.Log("小吉");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n小吉\n最高！！";
                }
                else if(210.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 270.0f)
                {
                    Debug.Log("末吉");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n末吉\nアゲてこ！！";
                }
                else if(270.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 330.0f)
                {
                    Debug.Log("中吉");
                    this.textBackGround.SetActive(true);
                    this.lotteryResult.SetActive(true);
                    this.lotteryResult.GetComponent<Text>().text= "くじ結果\n中吉\n最高！！";
                }
            }
        }

    }
}
