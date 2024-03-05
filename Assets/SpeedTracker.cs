using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedTracker : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI speedText;
    [SerializeField] Creature playerCreature;

    // Update is called once per frame
    void Update()
    {
        speedText.text = "This is the current speed:\n" + playerCreature.speed;
    }
}
