using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour {

    public GameObject Hero;
    public GameObject end;
    private bool paused = false;


    void Start()
    {
        end.SetActive(false);
    }


    void Update()
    {

        if (Hero.transform.position.y >= 47.0f)
        {
            paused = true;
        }

        if (paused)
        {
            end.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            end.SetActive(false);
            Time.timeScale = 1;

        }



    }
}
