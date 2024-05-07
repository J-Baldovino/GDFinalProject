using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverForWall : InteractableObject
{
    [SerializeField] GameObject fakeWall;
    private bool fakeWallActive = true;
    SpriteRenderer leverSprite;

    [SerializeField] LeverCounter leverCounter;

    void Awake(){
        leverSprite = GetComponent<SpriteRenderer>();
    }

    protected override void OnInteract()
    {
        if(fakeWallActive){
            base.OnInteract();
            leverSprite.flipX = false; //Flips the lever sprite on the X-axis
            fakeWallActive = false;
            GetComponent<AudioSource>().Play();
            LeverCounterSingleton.singleton.leversActivated++;

            //Deactivate the fake wall if the number of required levers is met
            if(leverCounter.numRequiredLevers == LeverCounterSingleton.singleton.leversActivated){
                 fakeWall.SetActive(!fakeWall.activeSelf);
            }
        }
    }

}
