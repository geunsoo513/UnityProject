using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecommissionFunction : MonoBehaviour
{
    private void OnDestroy()
    {
        Debug.Log("OnDestroy() 메소드 호출");
    }

    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit() 메소드 호출");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable() 메소드 호출");
    }
}
