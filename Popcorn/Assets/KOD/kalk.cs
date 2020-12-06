using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalk : MonoBehaviour
{
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("ko", true);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("ko", false);
        }
    }
}
