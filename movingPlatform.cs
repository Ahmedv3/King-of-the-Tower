using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatform : MonoBehaviour {

    //public GameObject player;

    public Transform pos1, pos2,startPos;
    public float platformSpeed;
    Vector3 nextPos;

  /*  void isCollision(GameObject player) 
    {
        if (player.transform.position.y >= 9.30)
        {
            player.transform.parent = transform;
        }
        else if(player.transform.position.y < 9.30 || player.transform.position.y > 9.45)
        {
            player.transform.parent = null;
        }
    } */

    // Use this for initialization
    void Start () {
        nextPos = startPos.position;
	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, platformSpeed);

      //  isCollision(player);
	}

}
