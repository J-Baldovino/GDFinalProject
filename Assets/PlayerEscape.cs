using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Creature>() != null){
            //Will implement a coroutine to allow the sound to play before switching scenes
            //GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("YouEscaped");
        }
    }
}
