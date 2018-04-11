using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {


    public int currentHealt = 100;
    private Animator anim;



    void Start () {
        anim = GetComponent<Animator>();
    }
	
	void Update () {
        

        if (currentHealt <= 0)
        {
            Destroy(gameObject);
        }

        anim.SetFloat("speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));

    }

    public void Damage(int damage){
        currentHealt -= damage;
        
    }
}
