using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text text;
    public static int score;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        // 젤리 획득 시 젤리 스크립트의 증가되는 값을 문자로 변환하여 text변수에 저장
        text.text = "Score : " + score.ToString();
    }
}
