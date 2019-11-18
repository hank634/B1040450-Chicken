using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B10404502 : MonoBehaviour
{
    Animator m_Animator;

   

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();

    }


    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
           m_Animator.SetTrigger("吃飯觸發器");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            m_Animator.ResetTrigger("吃飯觸發器");

        }

    }
}