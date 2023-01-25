using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject maincam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {

        //float temp = (maincam.transform.position.x * (1 - parallaxEffect));
        float dist = (maincam.transform.position.x * parallaxEffect);

        //transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        transform.position = new Vector3(startpos + dist, 5, transform.position.z);

        //if (temp > startpos + lenght) startpos += lenght;
        //else if (temp < startpos - lenght) startpos -= lenght;
    }
}
