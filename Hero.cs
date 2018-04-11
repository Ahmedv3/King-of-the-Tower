using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {


    public float moveSpeed;
    public float jummpHeight;
    public int maxHealth = 100;
    public int currentHealth;
 

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;
    private Animator anim;

    void Die(){
        Destroy(gameObject);
    }


    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jummpHeight);
    }

    void Start () {  
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;

    }

    void Update () {

        if (currentHealth > maxHealth) currentHealth = maxHealth;
        if (currentHealth <= 0) Die();

        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
            Jump();
            
        if (Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
    }

   

}
