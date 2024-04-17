using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNavMesh : MonoBehaviour
{
    [SerializeField] private Transform firstTransform;
    [SerializeField] private Transform secondTransform;
    [SerializeField] private NodeTree currentState;
    private Transform originTransform;
    private NavMeshAgent navMeshAgentagent;

    private void Awake()
    {
        navMeshAgentagent= transform.GetComponent<NavMeshAgent>();
        originTransform = firstTransform;
    }

    private void Start()
    {
        NavMeshAgent[] enemies = GameObject.FindObjectsOfType<NavMeshAgent>();
        StartCoroutine(EnableAgents(enemies));
    }

    IEnumerator EnableAgents(NavMeshAgent[] enemies)
    {
        foreach (NavMeshAgent agent in enemies) agent.enabled = false;
        yield return new WaitForSecondsRealtime(2.0f);
        foreach (NavMeshAgent agent in enemies)
        {
            agent.enabled = true;
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }

    void Update()
    {
        currentState = GetComponent<EnemyController>().currentState;
        if (GetComponent<EnemyController>().target == null) navMeshAgentagent.SetDestination(firstTransform.position);
        else firstTransform = null;

        if (currentState.name == "Run") firstTransform = originTransform;

        if(GetComponent<EnemyController>().HP <= 0) { navMeshAgentagent.enabled = false; }
    }

    public void ReturnPatrol()
    {
        firstTransform = originTransform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform == firstTransform)
        {
            firstTransform = secondTransform;
            secondTransform = originTransform;
            originTransform = firstTransform;
        }
    }
}
