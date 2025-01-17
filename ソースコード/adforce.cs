using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class adforce : MonoBehaviour
{
    public float x, y, z;
    public bool IsAdd = true;

    // 加速度
    private Vector3 _acceleration;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _acceleration = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        // AddForceで加速度を指定
        if (IsAdd)
        {
            _rigidbody.AddForce(_acceleration, ForceMode.Acceleration);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Del_Force"))
        {
            IsAdd = !IsAdd;
        }
    }
}