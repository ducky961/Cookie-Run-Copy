using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyController : MonoBehaviour
{
    // 오브젝트가 가지는 속도
    public float Speed = 1f;

    // 불러올 이미지
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // 오브젝트 움직임 설정
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌이 일어나면 score에 100점을 추가
        Score.score += 100;

        // 충돌이 되면 오브젝트 삭제
        Destroy(gameObject);
        
    }
}
