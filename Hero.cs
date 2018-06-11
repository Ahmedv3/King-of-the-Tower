using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Hero : MonoBehaviour {

    private bool damageTaken = false;
    private float damageTimer = 0;
    private float damageCd = 0.3f;

    public float moveSpeed;
    public float jummpHeight;
    public int maxHealth = 5;
    public int maxGems = 9;
    public int currentHealth;
    public int currentGems;


    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;

    private bool grounded;
    private Animator anim;
    private Animator anim2;

    void Die(){
        
        //restartCurrentScene();
    }

    public void restartCurrentScene(){
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }


    void FixedUpdate(){
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    void Jump(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jummpHeight);
    }

    void Start () {  
        anim = GetComponent<Animator>();
        anim2 = GetComponent<Animator>();
        currentHealth = maxHealth;

        currentGems = 0;

        damageTimer = damageCd;
    }

    public void Damage(int damage){
        currentHealth -= damage;
        damageTaken = true;
        
    }

    public void gem1Up(int gemUP)
    {
        currentGems += gemUP;

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

        if (damageTaken){
            if (damageTimer > 0){
                damageTimer -= Time.deltaTime;
            }
            else{
                damageTaken = false;
                damageTimer = damageCd;
            }

        }

        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        anim2.SetBool("damageTaken", damageTaken);
    }

   

}
