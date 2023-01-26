using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator anim;
    [SerializeField] PolygonCollider2D colli;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)

    {
        FoxFire temp = collision.gameObject.GetComponent<FoxFire>();

        if (temp != null)
        {
            anim.SetTrigger("IsHit");
            Destroy(colli);
        }
    }
}
