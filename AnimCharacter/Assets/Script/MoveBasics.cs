using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBasics : MonoBehaviour
{
   private float horizontalInput;
   private Rigidbody2D rb;
   public int speed;
   public int jump;
   public Transform player;
   public LayerMask chaoLayer;
   private bool isChao;

   private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Attack();
    }

    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity= new Vector2(horizontalInput * speed, rb.velocity.y);

        float input = Input.GetAxis("Horizontal");

        if (input > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);
            anim.SetBool("walk", true);
        }
        if (input < 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
            anim.SetBool("walk", true);
        }
        if (input == 0)
        {
            anim.SetBool("walk", false);
        }

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isChao)
        {
            rb.AddForce(Vector2.up * jump);
            anim.SetTrigger("jump");
        }
        isChao = Physics2D.OverlapCircle(player.position, 0.2f, chaoLayer);
    }
    void Attack(){
        if(Input.GetKeyDown(KeyCode.F)){
            anim.SetTrigger("attack");
        }
    }
}    