using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnCheckpoint : MonoBehaviour
{
    private Vector3 respawnPoint;

    [SerializeField] float respawntimer;
    [SerializeField] Animator playerAnimator;
    [SerializeField] private Player_Death playerDeathScript;

    HealthScript refScript;

    // Start is called before the first frame update
    void Start()
    {
        refScript = GetComponent<HealthScript>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator RespawnCoroutine()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(respawntimer);
        transform.position = respawnPoint;
        playerDeathScript.OnRespawn();
        playerAnimator.Play("Anim_Player_Idle");

    }



        void OnCollisionEnter2D(Collision2D collision)
    {
        //DealsDMGtoPlayer temp = collision.gameObject.GetComponent<DealsDMGtoPlayer>();
        //if (temp != null && isInvincible == false)
        //{
        //    refScript.health -= 1;
        //}
        //if (temp != null && refScript.health < 2)
        //{
        //    playerDeathScript.OnDeath();
        //    StartCoroutine(RespawnCoroutine());
        //}
       
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    void OnTriggerStay2D(Collider2D other)


    {
        DealsDMGtoPlayer temp = other.gameObject.GetComponent<DealsDMGtoPlayer>();
        
        if (temp != null && refScript.health < 1)
        {
            playerDeathScript.OnDeath();
            StartCoroutine(RespawnCoroutine());
            refScript.health = refScript.numOfHearts;
        }

        if (other.gameObject.tag == "Checkpoint")
        {
            Debug.Log("Happens");
            respawnPoint = transform.position;

        }
    }
}
