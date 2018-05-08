using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGems : MonoBehaviour {

    public int Up = 0;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger == true && col.CompareTag("Player"))
        {
            col.SendMessageUpwards("gem1Up", Up);
            Destroy(this.gameObject);
        }
    }
}
