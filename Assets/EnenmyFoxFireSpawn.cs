using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenmyFoxFireSpawn : MonoBehaviour
{
    [SerializeField] GameObject objectToSpawn;
    [SerializeField] float spawnTime = 3f;
    [SerializeField] float delay = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFire", delay, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFire()
    {
        var newFire = GameObject.Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
