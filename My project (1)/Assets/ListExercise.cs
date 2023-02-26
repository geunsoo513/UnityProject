using System.Collections.Generic;
using UnityEngine;

public class ListExercise : MonoBehaviour
{
   private void Awake()
    {
        //�Ϲ�ȭ �÷��� �ڷᱸ���� ���� ���� / �޸� �Ҵ��
        //���ĸŰ����� <T>�� ���Ǵ� ������ ������ �����Ѵ�.
        List<int> list = new List<int>();

        //��� �߰�(����)
        for(int i = 0; i < 5; ++i)
        {
            list.Add(i);
        }

        //����Ʈ�� ��� ��� ���
        //������ ������ �� list�� ���ĸŰ������� <int>�� ���ǵǾ��� ������
        //PrintList() �޼ҵ带 ȣ���� �� T�� �ٽ� �������� �ʾƵ� �ȴ�.

        PrintList<int>(list);

        //��� �߰� (���ϴ� ��ġ)
        list.Insert(0, 10000);

        //����Ʈ�� ��� ��� ���
        PrintList(list);

        //��� ����(�Ű� ������ �Էµ� ��ġ�� ���)
        list.RemoveAt(1);

        //����Ʈ�� ��� ��� ���
        PrintList(list);

        //���� ����Ʈ�� ����� ����� ����
        Debug.Log($"List Count : {list.Count}");



    }
    public void PrintList<T>(List<T> list)
    {
        Debug.Log("============================");
        for(int i = 0; i < list.Count; ++i)
        {
            Debug.Log($"list[{i}]={list[i]}");
        }
    }
}
