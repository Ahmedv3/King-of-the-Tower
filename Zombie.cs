using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {


    public int currentHealt = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(currentHealt <= 0){
            Destroy(gameObject);
        }
		
	}

    public void Damage(int damage){
        currentHealt -= damage;
        
    }
}
