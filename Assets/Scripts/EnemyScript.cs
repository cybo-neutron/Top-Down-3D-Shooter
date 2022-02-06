using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("References")]
    Rigidbody _rb;
    [SerializeField] Transform _target;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

    }
}
