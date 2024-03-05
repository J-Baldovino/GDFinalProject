using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{

    [SerializeField] float timeLeftInSeconds;
    [SerializeField] bool timerOn = false;
    [SerializeField] TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn){
            if(timeLeftInSeconds > 0){
                timeLeftInSeconds -= Time.deltaTime;
                updateTimer(timeLeftInSeconds);
            }
            else{
                Debug.Log("Time is UP!");
                timeLeftInSeconds = 0;
                timerOn = false;
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void updateTimer(float currentTime){
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
