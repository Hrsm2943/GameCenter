using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class adforce : MonoBehaviour
{
    public float x, y, z;
    public bool IsAdd = true;

    // ‰Á‘¬“x
    private Vector3 _acceleration;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _acceleration = new Vector3(x, y, z);
    }

    private void FixedUpdate()
    {
        // AddForce‚Å‰Á‘¬“x‚ðŽw’è
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