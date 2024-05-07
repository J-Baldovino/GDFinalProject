using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultyMenu : MonoBehaviour
{

    [SerializeField] Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNormal(){
        //Use this var once you complete the first map and reverse it
        SceneManager.LoadScene(1);
    }

    public void PlayDifficult(){
        //Use this var once you complete the first map and reverse it
        SceneManager.LoadScene(4);
    }

    //Create two more functions for the different map levels

    public void OpenOptions(){
        canvas.enabled = true;
    }

    public void CloseOptions(){
        canvas.enabled = false;
    }

}
