using System.Collections.Generic;
using UnityEngine;

public class QueueExercise1 : MonoBehaviour
{
    private void Awake() {
        //�Ϲ�ȭ �÷��� �ڷᱸ���� ���� ���� / �޸� �Ҵ��
        //���ĸŰ����� <T>�� ���Ǵ� ������ ������ �����Ѵ�.
        Queue<int> queue = new Queue<int>();

        //�Ĵܿ� ���ο� ��� �߰�
        for (int i = 0; i < 5; ++i)
        {
            queue.Enqueue(i);
        }

        //���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");

        //queue.Count�� 0�� �� ������ �ݺ�
        while (queue.Count > 0)
        {
            //���ܿ� �ִ� ��� ���� ��, ������ ���
            Debug.Log($"Queue Data : {queue.Dequeue()}");
        }
        //���� ť�� ����� ����� ����
        Debug.Log($"Queue Count : {queue.Count}");
    }
}
