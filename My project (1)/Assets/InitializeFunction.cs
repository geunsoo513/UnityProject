using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeFunction : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake() 메소드 실행");
    }

    private void Start()
    {
        Debug.Log("Start() 메소드 실행");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable() 메소드 실행");
    }
}
