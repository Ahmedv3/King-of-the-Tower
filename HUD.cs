using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] heartsSprites;

    public Image HeartsUI;
    private Hero player;

    void Start(){

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Hero>();
        
    }
    void Update(){

        HeartsUI.sprite = heartsSprites[player.currentHealth];
        HeartsUI.transform.position = player.transform.position + new Vector3(-5.0f,5.3f,0.0f);

        
    }


}
