using System.Collections;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }
        //���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");

        //���ܿ� �ִ� ��Ҹ� �������� �ʰ� ��Ҹ� ��ȯ�� �� ���
        Debug.Log($"���� 0�� ��� : {queue.Peek()}");

        Debug.Log($"Queue Count : {queue.Count}");

        //���ܿ� �ִ� ��Ҹ� �����ϰ� ������ ��Ҹ� ��ȯ
        object data = queue.Dequeue();
        Debug.Log($"ť���� �������� ������ : {data}");
        Debug.Log($"Queue Count : {queue.Count}");

        //ť�� ��� ��� ����
        queue.Clear();
        Debug.Log($"Queue Count : {queue.Count}");

    }
}