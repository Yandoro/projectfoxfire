using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnCheckpoint : MonoBehaviour
{
    private Vector3 respawnPoint;
    private Rigidbody2D player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            transform.position = respawnPoint;
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Checkpoint")
        {
            Debug.Log("Happens");
            respawnPoint = transform.position;

        }
    }
}
