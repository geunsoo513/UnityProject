using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise02 : MonoBehaviour
{
   private void Awake()
    {
        string position = "3,5,6";
        //Split()�� �̿��� ���ڿ��� �����ϸ� ������ ������ŭ �迭�� ����
        //��ǥ(,)�� �������� ����
        string[] str = position.Split(',');
        Debug.Log($"{str[0]},{str[1]},{str[2]}");

        string str2 = "HELLO, WORLD";
        //7��° ��ġ���� �ڿ� �ִ� ���ڿ��� �ٽ� ����
        str2 = str2.Substring(7);
        Debug.Log(str2);


        /* 04. ���ڿ� ����
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
        Debug.Log(str + "���� üũ");

        str = str.Trim();//���ڿ��� ��, �� ���� ����
        //str=str.TrimStart(); : ���ڿ��� �� ���� ����
        //str=str.TrimEnd();//���ڿ��� �� ���� ����
        Debug.Log(str + "���� üũ");

        Debug.Log($"Before Replace : {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");
     


        /*
        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o�� �տ������� {numeric + 1}��°�� �ִ�.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o�� �ڿ������� {numeric}��°�� �ִ�.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str}������ Hello���� �����Ѵ�?{isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str}������ World���� �����Ѵ�?{isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str}������ Hello���� ������?{isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"{str}������ World���� ������?{isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str}���忡 Hell�� ���ԵǾ� �ִ�?{isTrue}");

        /* 02. string.Format() vs ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        //String.Format()
        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));

        //���ڿ� ����
        Debug.Log($"{minutes}:{seconds}");

        //string.Format()
        Debug.Log(string.Format("{0,-10:D5}", minutes));
        //���ڿ� ����
        Debug.Log($"{minutes,-10:D5}");


        /* 01. string.Format()�� �̿��� ���ڿ� ����
        int minutes = 1;
        int seconds = 15;

        //���� �׸� - ����
        Debug.Log(string.Format("�⺻ : {0}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("���� ���� : {0,-5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("������ ���� : {0,5}{1}{2}", minutes, ":", seconds));

        //���� �׸� - ���� ���ڿ� ���� (����)
        Debug.Log(string.Format("10���� ����ȭ : {0:D}", 123));
        Debug.Log(string.Format("10���� ����ȭ 5�ڸ� : {0:D5}", 123));

        Debug.Log(string.Format("16���� ����ȭ : {0:X}", 0x00));
        Debug.Log(string.Format("16���� ����ȭ 10�ڸ� : {0:X10}", 0x00));

        Debug.Log(string.Format("�����Ҽ��� ����ȭ : {0:F}", 1.23));
        Debug.Log(string.Format("�����Ҽ��� ����ȭ(�Ҽ��� 1�ڸ�) : {0:F1}", 1.23));

        Debug.Log(string.Format("�޸��� ���� : {0:N}", 1234567890));
        Debug.Log(string.Format("���� : {0:E}", 1234567890));

        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss(dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss(dddd)");
        Debug.Log(str);*/
    }
}
