using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1040450 : MonoBehaviour
{
    Animator m_Animator;

    [Header("跑步開關")] bool run;//設定一個變數為run

    void Start()
    {
       
        m_Animator = gameObject.GetComponent<Animator>();
       
        run = false;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            run = true;

        else run = false;

        if (run == false)
            m_Animator.SetBool("跑步開關", false);

        if (run == true)
            m_Animator.SetBool("跑步開關", true);
    }
}