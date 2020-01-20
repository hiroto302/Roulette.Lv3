using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZakuController : MonoBehaviour
{
    Animator animCtrl;
    public RouletteController roulette;
    float zakuFirstRotSpeed ;
    void Start()
    {
        animCtrl = GetComponent<Animator>();
        zakuFirstRotSpeed = roulette.firstRotSpeed;
        // zakuFirstRotSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if(0.5f < zakuFirstRotSpeed)
        // {
        //     animCtrl.SetBool("RotSpeed", true);
        // }
        // else
        // {
        //     animCtrl.SetBool("RotSpeed", false);
        // }

        // if(Input.GetMouseButtonDown(0))
        // {
        //     this.zakuFirstRotSpeed = 10.0f;
            // animCtrl.SetFloat("RotSpeedF", zakuFirstRotSpeed);
        // }
    }
}
