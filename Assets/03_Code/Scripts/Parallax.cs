using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float lenght, startpos;
    public GameObject maincam;
    public float parallaxEffect;
    [SerializeField] float yoffset = 10;
    [SerializeField] float xoffset = 48;


    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x + xoffset;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {

        //float temp = (maincam.transform.position.x * (1 - parallaxEffect));
        float dist = (maincam.transform.position.x * parallaxEffect);

        //transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        transform.position = new Vector3(startpos + dist, yoffset, transform.position.z);

        //if (temp > startpos + lenght) startpos += lenght;
        //else if (temp < startpos - lenght) startpos -= lenght;
    }
}
