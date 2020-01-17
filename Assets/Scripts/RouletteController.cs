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
        //回転機能
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 10.0f;
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.98f;
    }
}
