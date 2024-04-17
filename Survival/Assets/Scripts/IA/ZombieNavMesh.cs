using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private Transform moveTransformOrigin;
    private NavMeshAgent navMeshAgentagent;

    private void Awake()
    {
        navMeshAgentagent= transform.GetComponent<NavMeshAgent>();
        moveTransformOrigin = movePositionTransform;
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
        if (GetComponent<EnemyController>().target == null) navMeshAgentagent.SetDestination(movePositionTransform.position);
        else movePositionTransform = null;

        if(GetComponent<EnemyController>().HP <= 0) { navMeshAgentagent.enabled = false; }
    }

    public void ReturnPatrol()
    {
        movePositionTransform = moveTransformOrigin;
    }
}
