using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //回転スピード

    void Start()
    {
        
    }

    void Update()
    {

        //タップの制限
        if(this.rotSpeed == 0)
        {
            //回転機能
            if(Input.GetMouseButton(0))
            {
                this.rotSpeed = 10.0f;
            }
        }
        else
        {
            transform.Rotate(0, 0, this.rotSpeed);
            this.rotSpeed *= 0.98f;
            if(this.rotSpeed < 0.05f)
            {
                this.rotSpeed =0;

                //おみくじ機能 rouletteの角度で判断
                if(transform.localEulerAngles.z < 30.0f || 360.0f < transform.localEulerAngles.z)
                {
                    Debug.Log("凶");
                    Debug.Log(transform.localEulerAngles.z);
                }
                else if(30.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 90.0f)
                {
                    Debug.Log("大吉");
                    Debug.Log(transform.localEulerAngles.z);

                }
                else if(90.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 150.0f)
                {
                    Debug.Log("大凶");
                    Debug.Log(transform.localEulerAngles.z);
                }
                else if(150.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 210.0f)
                {
                    Debug.Log("小吉");
                    Debug.Log(transform.localEulerAngles.z);
                }
                else if(210.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 270.0f)
                {
                    Debug.Log("末吉");
                    Debug.Log(transform.localEulerAngles.z);
                }
                else if(270.0f <= transform.localEulerAngles.z && transform.localEulerAngles.z < 330.0f)
                {
                    Debug.Log("中吉");
                    Debug.Log(transform.localEulerAngles.z);
                }
            }
        }

    }
}
