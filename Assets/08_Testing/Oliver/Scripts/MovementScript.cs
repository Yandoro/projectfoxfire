using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MovementScript : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;
    public Foxfire LaunchFoxfirePrefab;
    public Transform LaunchOffset;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(LaunchFoxfirePrefab, LaunchOffset.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        // Move our Character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }
}
