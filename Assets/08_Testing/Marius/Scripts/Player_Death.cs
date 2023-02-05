using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Death : MonoBehaviour
{
    public Animator animator;
    private int lastLayerMask;
    private bool isDeath = false;
    private Rigidbody2D player;
    public bool IsDeath { get => isDeath;  }
    [SerializeField] private int DeathLayer;

    public void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }
    public void OnDeath()
    {
        isDeath = true;
        animator.Play("Anim_Player_Death");
        lastLayerMask = gameObject.layer;
        gameObject.layer = DeathLayer;
        player.velocity = Vector3.zero;

    }
    public void OnRespawn()
    {
        gameObject.layer = lastLayerMask;
        isDeath = false;
    }
}
