using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_BushParallax : MonoBehaviour
{
    [SerializeField] GameObject bushParallax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bushParallax.SetActive(false);
        Debug.Log("HitBush");
    }
}
