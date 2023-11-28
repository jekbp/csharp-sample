using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Chapter0301
{
    public class IntegralTypes : MonoBehaviour
    {
        void Start()
        {
            {
            sbyte a = -10;
            byte b = 40;

            Debug.Log($"a = {a}, b = {b}");  //$ 붙이면 쌍따옴표 사이의 값 중 중괄호 사이의 값은 변수를 불러온다

            short c = -30000;
            ushort d = 60000;

            Debug.Log($"c = {c}, d = {d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            Debug.Log($"e = {e}, f = {f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            Debug.Log($"g = {g}, h = {h}");
            Debug.Log("g = " + g + ", h = " + h);
            Debug.Log(string.Format("g = {0}, h = {1}", g, h));
            }

            //-------------------------------------------------------
            {
            byte a = 255;
            sbyte b = (sbyte)a;

            Debug.Log(a); //255 출력
            Debug.Log(b); //-1 출력
            }

            {
                uint a = uint.MaxValue; //최댓값 대입

                Debug.Log(a); //4294967295출력

                a = a + 1;

                Debug.Log(a); //0출력(오버플로우)
            }

            {
                float a = 3.1415_9265_3589_7932_3846f;
                Debug.Log(a);

                double b = 3.1415_9265_3589_7932_3846;
                Debug.Log(b);
            }
        }
    }
}