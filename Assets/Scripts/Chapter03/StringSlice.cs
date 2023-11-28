using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSlice : MonoBehaviour
{
    void Start()
    {
        string greeting = "Good Morning";

        Debug.Log(greeting.Substring(0,5)); //"Good", 괄호 안의 값이 2개면 자르고자 하는 시작과 끝
        Debug.Log(greeting.Substring(5)); //"Morning", 괄호 안의 값이 1개면 자르는 시작점

        string[] arr = greeting.Split(new string[] {" "}, System.StringSplitOptions.None); //공백을 기준으로 문자열을 자르겠다, using System을 쓰면 앞에 System 없어도 된다.

        foreach(string element in arr)
            Debug.Log($"{element}");
    }
}