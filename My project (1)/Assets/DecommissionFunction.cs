using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecommissionFunction : MonoBehaviour
{
    private void OnDestroy()
    {
        Debug.Log("OnDestroy() �޼ҵ� ȣ��");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit() �޼ҵ� ȣ��");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable() �޼ҵ� ȣ��");
    }
}
