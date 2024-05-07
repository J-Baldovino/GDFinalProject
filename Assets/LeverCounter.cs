using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LeverCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI leverCounterText;

    public int sceneID;

    public int numRequiredLevers;
    // [SerializeField] Creature playerCreature;

    void Awake(){
        sceneID = SceneManager.GetActiveScene().buildIndex;
        SetRequiredLevers();
    }

    // Update is called once per frame
    void Update()
    {
        leverCounterText.text = "Activated Levers: " + LeverCounterSingleton.singleton.leversActivated + "/" + numRequiredLevers;
    }

    //Sets the number of levers required to escape the level
    void SetRequiredLevers(){
        switch(sceneID){
            case 1:
                numRequiredLevers = 1;
                break;
        }
    }
}
