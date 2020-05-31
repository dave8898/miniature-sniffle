using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed = 3f;
    [SerializeField] float jumpSpeed = 4f;

    Rigidbody2D myRigidbody;
    Collider2D myFeet;
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myFeet = GetComponent<BoxCollider2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }
    }

    private void Jump()
    {
        if (myFeet.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            var jumpVar = Input.GetAxis("Jump");
            Vector2 movePlayerJump = new Vector2(myRigidbody.velocity.x, jumpVar * jumpSpeed);
            myRigidbody.velocity = movePlayerJump;

            bool playerHasVerticalSpeed = (Mathf.Abs(myRigidbody.velocity.y) > Mathf.Epsilon);
            myAnimator.SetBool("Jumping", playerHasVerticalSpeed);

        }
    }

    private void Move()
    {
        var moveVar = Input.GetAxis("Horizontal");
        Vector2 movePlayer = new Vector2(moveVar * Time.deltaTime * moveSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = movePlayer;

        bool playerHasHorizontalSpeed = (Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon); 
        myAnimator.SetBool("Running", playerHasHorizontalSpeed);
        FindObjectOfType<QuadMover>().MoveQuad(moveVar);
    }

}
