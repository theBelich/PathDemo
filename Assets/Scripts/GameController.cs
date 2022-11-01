using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor.AI;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _greenSurfacePrefab;
    [SerializeField] private GameObject _yellowSurfacePrefab;
    [SerializeField] private Transform _surfaceParent;


    // Use this for initialization
    void Start()
    {
        BuildNavMeshes();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                var a = Instantiate(_greenSurfacePrefab, hit.point, Quaternion.identity);
                a.transform.SetParent(_surfaceParent);
                BuildNavMeshes();
            }
        }
    }

    public void RandomizeLevel()
    {

    }

    private void BuildNavMeshes()
    {
        UnityEditor.AI.NavMeshBuilder.ClearAllNavMeshes();
        UnityEditor.AI.NavMeshBuilder.BuildNavMesh();
    }
}

