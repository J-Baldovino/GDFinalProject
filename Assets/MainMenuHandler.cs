using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        //Use this var once you complete the first map and reverse it
        // int mazeVariant = Random.Range(1,3);
        SceneManager.LoadScene(1);
    }

    public void ReturnToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit(){
        Application.Quit();
    }
}
