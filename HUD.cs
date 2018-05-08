using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] heartsSprites;
    public Sprite[] gemsSprites;
    public Image HeartsUI;
    public Image Gem;
    public Image gemsMany;
    private Hero player;

    void Start(){

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Hero>();
        
    }
    void Update(){

        HeartsUI.sprite = heartsSprites[player.currentHealth];
        HeartsUI.transform.position = player.transform.position + new Vector3(-5.0f, 5.3f, 0.0f);

       Gem.transform.position = player.transform.position + new Vector3(4.5f, 5.2f, 0.0f);

        gemsMany.sprite = gemsSprites[player.currentGems];
        gemsMany.transform.position = player.transform.position + new Vector3(5.5f, 5.2f, 0.0f);


    }


}
