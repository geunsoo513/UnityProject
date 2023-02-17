using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise02 : MonoBehaviour
{
   private void Awake()
    {
        string position = "3,5,6";
        //Split()을 이용해 문자열을 분할하면 분할한 개수만큼 배열에 저장
        //쉼표(,)를 기준으로 분할
        string[] str = position.Split(',');
        Debug.Log($"{str[0]},{str[1]},{str[2]}");

        string str2 = "HELLO, WORLD";
        //7번째 위치부터 뒤에 있는 문자열만 다시 저장
        str2 = str2.Substring(7);
        Debug.Log(str2);


        /* 04. 문자열 변형
        string str = "HELLO,WORLD";
        Debug.Log(str);

        str = str.ToLower();
        Debug.Log($"ToLower()-{str}");

        str = str.ToUpper();
        Debug.Log($"ToUpper()-{str}");

        str = str.Insert(0, "Hi~ ");
        Debug.Log($"Insert() - {str}");

        str=str.Remove(0, 4);
        Debug.Log($"Remove() - {str}");

        Debug.Log("== Trim ==");

        str = "  " + str + "  ";
        Debug.Log(str + "공백 체크");

        str = str.Trim();//문자열의 앞, 뒤 공백 제거
        //str=str.TrimStart(); : 문자열의 앞 공백 제거
        //str=str.TrimEnd();//문자열의 뒤 공백 제거
        Debug.Log(str + "공백 체크");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");
     


        /*
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o는 앞에서부터 {numeric + 1}번째에 있다.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o는 뒤에서부터 {numeric}번째에 있다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str}문장은 Hello부터 시작한다?{isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str}문장은 World부터 시작한다?{isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str}문장은 Hello부터 끝난다?{isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str}문장은 World부터 끝난다?{isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str}문장에 Hell이 포함되어 있다?{isTrue}");

        /* 02. string.Format() vs 문자열 보간
        int minutes = 1;
        int seconds = 15;

        //String.Format()
        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));

        //문자열 보간
        Debug.Log($"{minutes}:{seconds}");

        //string.Format()
        Debug.Log(string.Format("{0,-10:D5}", minutes));
        //문자열 보간
        Debug.Log($"{minutes,-10:D5}");


        /* 01. string.Format()을 이용한 문자열 가공
        int minutes = 1;
        int seconds = 15;

        //서식 항목 - 맞춤
        Debug.Log(string.Format("기본 : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0,-5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0,5}{1}{2}", minutes, ":", seconds));

        //서식 항목 - 서식 문자열 설정 (숫자)
        Debug.Log(string.Format("10진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화 5자리 : {0:D5}", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화 10자리 : {0:X10}", 0x00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F}", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : {0:E}", 1234567890));

        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss(dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss(dddd)");
        Debug.Log(str);*/
    }
}
