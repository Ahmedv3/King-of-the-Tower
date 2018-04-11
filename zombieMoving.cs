using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMoving : MonoBehaviour {

    public Transform pos1, pos2, startPos;
    public float zombieSpeed;
    Vector3 nextPos;

    void Start(){
        nextPos = startPos.position;
    }

    void Update(){

        if (transform.position == pos1.position){
            nextPos = pos2.position;
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (transform.position == pos2.position){
            nextPos = pos1.position;
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, zombieSpeed);

    }
}
