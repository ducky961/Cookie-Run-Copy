using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    SpriteRenderer spriteRenderer;
    Rigidbody2D rigid;
    Animator anim;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {

        // 점프
        if (Input.GetKeyDown(KeyCode.W))
        {
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

            anim.SetBool("isJump",true);
        }

        // 슬라이드
        if (Input.GetKey(KeyCode.S))
        {

        }

    }
}
