using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateFunction : MonoBehaviour
{
    private void Update()
    {
        Debug.Log("Update() �޼ҵ� ����");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate() �޼ҵ� ����");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate() �޼ҵ� ����");
    }
}
