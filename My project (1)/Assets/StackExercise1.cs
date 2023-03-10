using System.Collections.Generic;
using UnityEngine;

public class StackExercise1 : MonoBehaviour
{
   private void Awake()
    {
        //일반화 컬렉션 자료구조는 변수 선언 / 메모리 할당시
        //형식매개변수 <T>에 사용되는 데이터 형식을 지정한다.
        Stack<int> stack = new Stack<int>();

        //스택의 최상위에 새로운 요소 추가
        for(int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }

        //현재 스택에 저장된 요소의 개수
        Debug.Log($"Stack Count : {stack.Count}");

        //stack.Count가 0이 될 때까지 반복
        while (stack.Count > 0)
        {
            //최상위에 있는 요소를 삭제하고 Debug.Log()로 데이터 출력
            Debug.Log($"Stack Data : {stack.Pop()}");
        }

        //현재 스택에 저장된 요소의 개수
        Debug.Log($"Stack Count : {stack.Count}");
    }
}
