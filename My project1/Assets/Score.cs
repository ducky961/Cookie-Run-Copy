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
        // ���� ȹ�� �� ���� ��ũ��Ʈ�� �����Ǵ� ���� ���ڷ� ��ȯ�Ͽ� text������ ����
        text.text = "Score : " + score.ToString();
    }
}
