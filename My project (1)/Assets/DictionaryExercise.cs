using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExercise : MonoBehaviour
{
    private void Awake()
    {
        //�Ϲ�ȭ �÷��� �ڷᱸ���� ���� ���� / �޸� �Ҵ��
        //���ĸŰ����� <T>�� ���Ǵ� ������ ������ �����Ѵ�.
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        //��� �߰�([] ������)
        dictionary["1"] = "First";
        dictionary["2"] = "Second";
        dictionary["3"] = "Third";


        //��ųʸ��� ��� ��� ���
        PrintDictionary(dictionary);

        //��� �߰�(Add �޼ҵ�)
        dictionary.Add("���", "Apple");

        //��ųʸ��� ��� ��� ���
        PrintDictionary(dictionary);

        //��ųʸ����� �Ű������� �Էµ� "1"�� Ű�� ������ ��� ����
        dictionary.Remove("1");

        //��ųʸ��� ��� ��� ���
        PrintDictionary(dictionary);



    }

    public void PrintDictionary<Tkey,TValue>(Dictionary<Tkey,TValue> dic)
    {
        Debug.Log("=====================================");

        //���� ��ųʸ��� ����� ����� ����
        Debug.Log($"Dictionary Count : {dic.Count}");

        //���� ��ųʸ��� ����� ��� ��� ���
       foreach(var d in dic.Keys)
        {
            Debug.Log($"dictionary[{d}]={dic[d]}");
        }
    }
}
