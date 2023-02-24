using System.Collections;
using UnityEngine;

public class HashtableExercise : MonoBehaviour
{

    private void Awake()
    {
       
        Hashtable hash = new Hashtable();

       
        Goblin goblin = new Goblin();
        Slime slime = new Slime();

       //요소 추가
        hash["Goblin"] = goblin;

        //요소 추가 - Add 케소드

        hash.Add("Slime", slime);
        hash.Add(1, "정수");
        hash.Add(1.2f, "실수");
        hash.Add("안녕하세요, 홍길동입니다.", "문자열");

        
        foreach (object key in hash.Keys)
        {
            Debug.Log($"hash[{key}]={hash[key]}");
        }

        //해시테이블에 slime키를 가지는 요소가 있는지 탐색
        if (hash.ContainsKey("Slime"))
        {
            Debug.Log($"Slime키 존재");
        }

        if (hash.ContainsValue(goblin))
        {
            Debug.Log($"{goblin} 값 존재");
        }

        
        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Remove("Slime");

        Debug.Log($"Hashtable Count : {hash.Count}");

        hash.Clear();
        Debug.Log($"Hashtable Count : {hash.Count}");

    }

}

public class Goblin { }
public class Slime { }