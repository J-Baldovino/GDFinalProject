using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEscape : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Creature>() != null){
            //Will implement a coroutine to allow the sound to play before switching scenes
            //GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("YouEscaped");
        }
    }
}
