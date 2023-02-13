using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFunction : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("Update() 메소드 실행");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate() 메소드 실행");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate() 메소드 실행");
    }
}
