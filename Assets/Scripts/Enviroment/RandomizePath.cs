using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePath : MonoBehaviour
{
    [SerializeField] private GameObject _greenTarget;
    [SerializeField] private GameObject _yellowTarget;
    [SerializeField] private GameObject _greenObstacle;
    [SerializeField] private GameObject _yellowObstacle;
    // Start is called before the first frame update
    void Start()
    {
        RandomizeYellowPath();
        RandomizeGreenPath();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizeYellowPath()
    {
        float x = Random.Range(0, 10);
        float z = Random.Range(2.5f, -7);
        _yellowTarget.transform.position = new Vector3(x, 0, z);

        x = _yellowTarget.transform.position.x - Random.Range(3, 7);
        z = _yellowTarget.transform.position.z - Random.Range(3, 7);
        _yellowObstacle.transform.position = new Vector3(x, 0, z);
    }

    public void RandomizeGreenPath()
    {
        float x = Random.Range(0, 10);
        float z = Random.Range(8.4f, 20);
        _greenTarget.transform.position = new Vector3(x, 0, z);

        x = _greenTarget.transform.position.x - Random.Range(3, 7);
        z = _greenTarget.transform.position.z - Random.Range(3, 7);
        _greenObstacle.transform.position = new Vector3(x, 0, z);
    }

    
}
