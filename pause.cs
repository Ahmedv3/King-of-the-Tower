using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {

    public GameObject pauseUI;
    private bool paused = true;


    void Start(){
        pauseUI.SetActive(true);
    }

    void Update(){

        if (Input.GetButtonDown("Pause")){
            paused = !paused;
        }

        if (paused){
            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused){
            pauseUI.SetActive(false);
            Time.timeScale = 1;

        }


    }

    public void resume()
    {
        paused = false;
    }

    public void restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void quit()
    {
        Application.Quit();
    }

}
