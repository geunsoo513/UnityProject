using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise03 : MonoBehaviour
{
    [SerializeField] // 변수 값 변경 가능
    private int x = 10;

    private void Awake()
    {
        // 05. 반복문 while
        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;
            index++;
        }

        Debug.Log($"1부터 100까지의 합은 {result}");



        /* 04. 반복문 for
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

        /* 03. 조건문 switch - case
        x /= 10;
        switch (x)
        {
            case 10:
                Debug.Log("학점 : A+");
                break;

            case 9:
                Debug.Log("학점 : A+");
                break;

            case 8:
                Debug.Log("학점 : B+");
                break;

            case 7:
                Debug.Log("학점 : C+");
                break;

            case 6:
                Debug.Log("학점 : D");
                break;

            default:
                Debug.Log("학점 : F");
                break;
        }



        /* 02. 조건문(if - else if - else)
        if (x >= 90)
        {
            Debug.Log("학점 : A+");
        }

        else if(x >= 80)
        {
            Debug.Log("학점 : B+");
        }

        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }

        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }

        else
        {
            Debug.Log("학점 : F");
        }

        /* 01. 조건문 if
        if (x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }

        else
        {
            Debug.Log("x는 홀수다");
        }

        //앞에서 배운 연산자를 이용해 조건문 내부에
        //여러개의 조건식을 동시에 만족하도록 설정 가능

        if (x > 5 && x < 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        //조건문 내부에 중첩해서 조건문 작성 가능
        //위의 if 조건문과 같은 결과를 출력할 것이다.

        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }
        Debug.Log($"x의 값은 {x}");
        */
    }

        
}
