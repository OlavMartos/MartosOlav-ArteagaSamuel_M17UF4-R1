using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseBehaviour : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Chase(Transform target, Transform self)
    {
        rb.velocity = (target.position - self.position).normalized * speed;
    }

    public void Run(Transform target, Transform self)
    {
        rb.velocity = (target.position - self.position).normalized * -speed;
    }

    public void StopChasing()
    {
        rb.velocity = Vector3.zero;
    }
}
