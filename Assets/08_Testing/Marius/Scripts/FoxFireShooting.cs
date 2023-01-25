using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxFireShooting : MonoBehaviour
{
    public Transform projectileSpawnpoint;
    public GameObject projectileFoxFire;
    private Camera mainCam;
    private Vector3 mousePos;

    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("Attacks");
            Launch();
        }
    }

    void Launch()
    {
        Instantiate(projectileFoxFire, projectileSpawnpoint.position, projectileSpawnpoint.rotation);
    }
}
