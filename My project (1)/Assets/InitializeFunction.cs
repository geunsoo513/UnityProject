using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeFunction : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake() �޼ҵ� ����");
    }

    private void Start()
    {
        Debug.Log("Start() �޼ҵ� ����");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable() �޼ҵ� ����");
    }
}
