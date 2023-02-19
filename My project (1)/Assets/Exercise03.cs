using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    [SerializeField] // ���� �� ���� ����
    private int x = 10;

    private void Awake()
    {
        // 05. �ݺ��� while
        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;
            index++;
        }

        Debug.Log($"1���� 100������ ���� {result}");



        /* 04. �ݺ��� for
        for(int index = 0; index < 10; ++index)
        {
            Debug.Log(index);
        }

        for(int x = 1; x < 10; ++x)
        {
            for(int y = 1; y < 10; ++y)
            {
                Debug.Log($"{x}*{y}={x * y}");
            }
        }

        /* 03. ���ǹ� switch - case
        x /= 10;
        switch (x)
        {
            case 10:
                Debug.Log("���� : A+");
                break;

            case 9:
                Debug.Log("���� : A+");
                break;

            case 8:
                Debug.Log("���� : B+");
                break;

            case 7:
                Debug.Log("���� : C+");
                break;

            case 6:
                Debug.Log("���� : D");
                break;

            default:
                Debug.Log("���� : F");
                break;
        }



        /* 02. ���ǹ�(if - else if - else)
        if (x >= 90)
        {
            Debug.Log("���� : A+");
        }

        else if(x >= 80)
        {
            Debug.Log("���� : B+");
        }

        else if (x >= 70)
        {
            Debug.Log("���� : C+");
        }

        else if (x >= 60)
        {
            Debug.Log("���� : D");
        }

        else
        {
            Debug.Log("���� : F");
        }

        /* 01. ���ǹ� if
        if (x % 2 == 0)
        {
            Debug.Log("x�� ¦����");
        }

        else
        {
            Debug.Log("x�� Ȧ����");
        }

        //�տ��� ��� �����ڸ� �̿��� ���ǹ� ���ο�
        //�������� ���ǽ��� ���ÿ� �����ϵ��� ���� ����

        if (x > 5 && x < 10)
        {
            Debug.Log("x�� 5���� ũ�� 10���� �۴�");
        }

        //���ǹ� ���ο� ��ø�ؼ� ���ǹ� �ۼ� ����
        //���� if ���ǹ��� ���� ����� ����� ���̴�.

        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x�� 5���� ũ�� 10���� �۴�");
            }
        }
        Debug.Log($"x�� ���� {x}");
        */
    }

        
}
