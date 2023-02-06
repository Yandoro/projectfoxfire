using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class FoxFire : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ExampleCoroutine());
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        rb.velocity = transform.right * speed;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(.9f);

        //After we have waited 5 seconds print the time again.
        spriteRenderer.sprite = newSprite;
        rb.velocity = transform.right * -speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(collision.name);
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.name);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log(collision.name);
            Destroy(gameObject);
        }
    }


}
