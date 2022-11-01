using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeController : MonoBehaviour
{
    [SerializeField] private Transform _targetDestination;
    [SerializeField] private RandomizePath _controller;
    private NavMeshAgent agent;
    private Vector3 startPosition;

    // Start is called before the first frame update
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startPosition = gameObject.transform.position;
    }

    private void FixedUpdate()
    {
        agent.SetDestination(_targetDestination.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        _controller.RandomizePathLength();
        gameObject.transform. position = startPosition;
    }

}
