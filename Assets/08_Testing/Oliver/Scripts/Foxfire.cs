using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foxfire : MonoBehaviour
{
    public float Speed = 4;
    public Vector3 LaunchOffset;
    public bool Thrown;
    // Start is called before the first frame update
    void Start()
    {
        if (Thrown)
        {
            var direction = -transform.right + Vector3.up;
            GetComponent<Rigidbody2D>().AddForce(direction * Speed, ForceMode2D.Impulse);
        }
        transform.Translate(LaunchOffset);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Thrown)
        {
        transform.position += -transform.right * Speed * Time.deltaTime;
        }

    }
}
