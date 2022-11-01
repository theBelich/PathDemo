using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePath : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private GameObject _yellowTarget;
    [SerializeField] private GameObject _greenTarget;
    // Start is called before the first frame update
    void Start()
    {
        RandomizePathLength();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizePathLength()
    {
        float x = Random.Range(0, 10);
        float z = Random.Range(2.5f, -7);
        _yellowTarget.transform.position = new Vector3(x, 0, z);

        x = Random.Range(0, 10);
        z = Random.Range(8.4f, 20);
        _greenTarget.transform.position = new Vector3(x, 0, z);
    }
}
