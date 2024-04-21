using UnityEngine;
using UnityEngine.AI;

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
        GetComponent<NavMeshAgent>().enabled = false;
        rb.velocity = (target.position - self.position).normalized * speed;
    }

    public void Run(Transform target, Transform self)
    {
        rb.velocity = (target.position - self.position).normalized * -speed;
    }

    public void StopChasing()
    {
        GetComponent<NavMeshAgent>().enabled = true;
        GetComponent<ZombieNavMesh>().ReturnPatrol();
        rb.velocity = Vector3.zero;
    }
}
