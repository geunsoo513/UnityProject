using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
   private void Awake()
    {
        Debug.Log("게임을 시작하면 Awake() 메소드에 있는 내용이 1회 실행된다.");

        Debug.Log("Debug.log() 괄호 내부에 작성한 내용은 Console View에 출력된다.");
    }
}
