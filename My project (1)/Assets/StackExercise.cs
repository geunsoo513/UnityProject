using System.Collections;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    private void Awake()
    {
        //�÷��� �ڷᱸ���� ������ ������ new�� �޸𸮸� �Ҵ��ؾ� ����� �� �ִ�.
        Stack stack = new Stack();
        //������ �ֻ����� ���ο� ��� �߰�
        for (int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }

        //���� ���ÿ� ����� ����� ����
        Debug.Log($"Stack Count : {stack.Count}");

        //������ �ֻ��� ��Ҹ� �������� �ʰ�, ��Ҹ� ��ȯ�� �� ���
        Debug.Log($"�������� �߰��� ��� : {stack.Peek()}");

        Debug.Log($"Stack Count : {stack.Count}");

        object data = stack.Pop();
        Debug.Log($"���ÿ��� �������� ������ : {data}");

        //������ ��� ��� ����
        stack.Clear();
        Debug.Log($"Stack Count : {stack.Count}");

    }
}