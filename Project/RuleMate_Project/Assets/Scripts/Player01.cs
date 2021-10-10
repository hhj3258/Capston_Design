using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01 : PlayerManager
{
    void Start()
    {
        playerPrefab = GameObject.Find("TestPlayer1");
        rigid = playerPrefab.GetComponent<Rigidbody>();
        anim = playerPrefab.GetComponent<Animator>();
    }

    void Update()
    {
        Jump();

        SetAnim();

        if (im.keyCatchOrRelease)
            CatchOrRelease();
    }

    void FixedUpdate()
    {
        Move();
        Turn();
    }

    protected override void SetAnim()
    {
        if (im.h != 0 || im.v != 0)
            anim.SetBool("isMove", true);
        else
            anim.SetBool("isMove", false);
    }
}