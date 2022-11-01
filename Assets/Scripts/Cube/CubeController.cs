using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Transform _targetDestination;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine(LateStart());
    }

    private IEnumerator LateStart()
    {
        yield return new WaitForSeconds(0.1f);
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(_targetDestination.position);
    }
}
