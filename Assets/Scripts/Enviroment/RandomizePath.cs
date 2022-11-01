using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizePath : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _obstacle;
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
        float z = Random.Range(-7, 20);
        _target.transform.position = new Vector3(x, 0, z);
        _target.transform.GetChild(0).GetChild(0).gameObject.isStatic = true;

        x = _target.transform.position.x - Random.Range(3, 7);
        z = _target.transform.position.z - Random.Range(3, 7);
        _obstacle.transform.position = new Vector3(x, 0, z);
    }    
}
