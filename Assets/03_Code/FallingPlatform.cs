using System.Collections;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    //[SerializeField] float fallDelay = 1f;
    private float destroyDelay = 2f;

    [SerializeField] private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            PlatformManager.Instance.StartCoroutine("SpawnPlatform",
                    new Vector2(transform.position.x, transform.position.y));
            Invoke("DropPlatform", 0.5f);
            Destroy(gameObject, destroyDelay);
        }
    }

    void DropPlatform()
    {
        rb.isKinematic = false;
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        StartCoroutine(Fall());

    //    }
    //}

    //private IEnumerator Fall()
    //{
    //    yield return new WaitForSeconds(fallDelay);
    //    rb.bodyType = RigidbodyType2D.Dynamic;
    //    Destroy(gameObject, destroyDelay);

    //}

}