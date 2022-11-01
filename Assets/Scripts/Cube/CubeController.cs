using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Transform _targetDestination;
    [SerializeField] private EventController _controller;
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        _agent.SetDestination(_targetDestination.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        _controller.CubeArrived();
    }
}
