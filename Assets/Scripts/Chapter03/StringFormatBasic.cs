using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StringFormatBasic : MonoBehaviour
{
    void Start()
    {
        string fmt = "{0, -20}{1,-15}{2, 30}"; //중괄호 앞 숫자들은 각각 0번, 1번, 2번을 의미한다. 뒤의 숫자는 위치를 의미한다. 각각 -20, -15, 30만큼의 공간 확보
        
        var result1 = string.Format(fmt, "Publischer", "Author", "Title");
        var result2 = string.Format(fmt, "Marvel", "Stan Lee", "Iron Man");
        var result3 = string.Format(fmt, "Hanbit", "Victor", "This is C#");
        var result4 = string.Format(fmt, "Prentice Hall", "K&R", "The C Programming Language");

        DateTime dt = new DateTime(2018, 11, 3, 23,18,22); //날짜 표현, 처리 (년, 월, 일, 시,분,초)

        Debug.Log(string.Format("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt));
        Debug.Log(string.Format("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (ddd)}", dt));

        CultureInfo ciKo = new CultureInfo("ko-KR");

        Debug.Log(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
        Debug.Log(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciKo));
        Debug.Log(dt.ToString(ciKo));

        CultureInfo ciEn = new CultureInfo("en-US");

        Debug.Log(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
        Debug.Log(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciEn));
        Debug.Log(dt.ToString(ciEn));
    }
}