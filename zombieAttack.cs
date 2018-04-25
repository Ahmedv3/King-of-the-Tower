using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieAttack : MonoBehaviour {


    private bool damage = false;
    private float damageTimer = 0;
    private float damageCd = 10.0f;

    public Collider2D damageTrigger;

    void Awake(){
       damageTrigger.enabled = false;
    }

    void Update(){
        damage = true;
        damageTimer = damageCd;
        damageTrigger.enabled = true;

        if (damage){
            if(damageTimer > 0){
                damageTimer -= Time.deltaTime;
            }
            else {
                damage = false;
                damageTrigger.enabled = false;
            }
        }
    }
}
