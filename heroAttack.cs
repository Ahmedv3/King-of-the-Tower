using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroAttack : MonoBehaviour {

    private bool Attacking = false;
    private float attackTimer = 0;
    private float attackCooldown = 0.3f;

    public Collider2D attackTrigger;

    private Animator anim;

    void Awake(){
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
    }

    void Update(){
        if(Input.GetKeyDown("z") && !Attacking){
            Attacking = true;
            attackTimer = attackCooldown;
            attackTrigger.enabled = true;
        }

        if (Attacking){
            if(attackTimer > 0){
                attackTimer -= Time.deltaTime;
            }
            else{
                Attacking = false;
                attackTrigger.enabled = false;
            }
        }

        anim.SetBool("Attacking", Attacking);
    }


}
