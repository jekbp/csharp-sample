using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        //IndexOf() 괄호안에 찾고자 하는 문자열 넣기
        Debug.Log($"IndexOf: 'Good' : {greeting.IndexOf("Good")}");
        Debug.Log($"IndexOf: 'o' : {greeting.IndexOf("o")}");
        
        //LastIndexOf() 뒤에서 부터 값을 찾는 형태
        Debug.Log($"LastIndexOf 'Good' : {greeting.LastIndexOf("Good")}");
        Debug.Log($"LastIndexOf 'o' : {greeting.LastIndexOf("o")}");

        //StartWith() 특정한 문자열로 시작 되는지
        Debug.Log($"StartWith 'Good' : {greeting.StartsWith("Good")}");
        Debug.Log($"StartWith 'g' : {greeting.StartsWith("Morning")}");

        //EndWith() 특정한 문자열로 종료가 되는지
        Debug.Log($"EndWith 'Good' : {greeting.EndsWith("Good")}");
        Debug.Log($"EndWith 'Morning' : {greeting.EndsWith("Morning")}");

        //Contains() 특정한 문자열을 포함하는지
        Debug.Log($"Contains 'Evening' : {greeting.Contains("Evening")}");
        Debug.Log($"Contains 'Morning' : {greeting.Contains("Morning")}");

        //Replace 특정한 문자열을 다른 문자열로 치환
        Debug.Log($"Repalced 'Morning' with 'Evening' : {greeting.Replace("Morning", "Evening")}");
    }
}
