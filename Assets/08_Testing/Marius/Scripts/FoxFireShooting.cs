using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxFireShooting : MonoBehaviour
{
    public Transform projectileSpawnpoint;
    public GameObject projectileFoxFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }
    }

    void Launch()
    {
        Instantiate(projectileFoxFire, projectileSpawnpoint.position, projectileSpawnpoint.rotation);
    }
}
