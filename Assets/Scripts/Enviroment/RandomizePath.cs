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
        SpawnObstacle();
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

    public void SpawnObstacle()
    {
        float x = _yellowTarget.transform.position.x - Random.Range(3, 7);
        float z = _yellowTarget.transform.position.z - Random.Range(3, 7);
        Instantiate(_obstaclePrefab, new Vector3(x, 0, z), Quaternion.identity);

        x = _greenTarget.transform.position.x - Random.Range(1, 5);
        z = _greenTarget.transform.position.z - Random.Range(1, 5);
        Instantiate(_obstaclePrefab, new Vector3(x, 0, z), Quaternion.identity);
    }
}
