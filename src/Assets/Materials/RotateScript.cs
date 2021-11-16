using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] public GameObject CenterPos = default;

    // ��]��
    [SerializeField] private Vector3 _axis = Vector3.up;

    // �~�^������
    [SerializeField] private float _period = 2;

    private void Update()
    {
        // ���S�_center�̎�����A��axis�ŁAperiod�����ŉ~�^��
        transform.RotateAround(
            CenterPos.transform.position,
            _axis,
            360 / _period * Time.deltaTime
        );
    }
}
