using System.Collections.Generic;
using UnityEngine;

public class StackExercise1 : MonoBehaviour
{
   private void Awake()
    {
        //�Ϲ�ȭ �÷��� �ڷᱸ���� ���� ���� / �޸� �Ҵ��
        //���ĸŰ����� <T>�� ���Ǵ� ������ ������ �����Ѵ�.
        Stack<int> stack = new Stack<int>();

        //������ �ֻ����� ���ο� ��� �߰�
        for(int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }

        //���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count : {stack.Count}");

        //stack.Count�� 0�� �� ������ �ݺ�
        while (stack.Count > 0)
        {
            //�ֻ����� �ִ� ��Ҹ� �����ϰ� Debug.Log()�� ������ ���
            Debug.Log($"Stack Data : {stack.Pop()}");
        }

        //���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count : {stack.Count}");
    }
}
