using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGems : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
