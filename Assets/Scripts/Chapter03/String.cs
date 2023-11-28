using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String : MonoBehaviour
{
    enum DialogResult{ YES, NO, CANCEL, CONFIRM, OK }

    // Start is called before the first frame update
    void Start()
    {
        {
            DialogResult result = DialogResult.YES;

            Debug.Log(result == DialogResult.YES);
            Debug.Log(result == DialogResult.NO);
            Debug.Log(result == DialogResult.CANCEL);
            Debug.Log(result == DialogResult.CONFIRM);
            Debug.Log(result == DialogResult.OK);
        }
        {
            string a = "안녕하세요";
            string b = "안녕하세요 입니다.";

            Debug.Log(a);
            Debug.Log(b);
        }

        {
            int a = 123;
            string b = a.ToString();
            Debug.Log(b);

            float c = 3.14f;
            string d = c.ToString();
            Debug.Log(d);

            string e = "123456";
            int f = Convert.ToInt32(e); //문자열을 32비트 숫자로 변환
            Debug.Log(f);

            string g = "1.2345";
            float h = float.Parse(g); //문자열을 float 타입으로 변환
            Debug.Log(h);
        }

        {
            //서버의 주소 같은 경우 상수로 선언
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;

            Debug.Log(MAX_INT);
            Debug.Log(MIN_INT);
        }
    }
}
