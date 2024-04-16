using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieNavMesh : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgentagent;
    private void Awake()
    {
        navMeshAgentagent= GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<EnemyController>().target == null)
        {
            navMeshAgentagent.destination=movePositionTransform.position;
        }
        else
        {
            movePositionTransform = null;
        }
    }
}
