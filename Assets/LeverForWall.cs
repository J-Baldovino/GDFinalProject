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

    int numRequiredLevers;
    // int sceneID;

    void Awake(){
        leverSprite = GetComponent<SpriteRenderer>();
        // int sceneID = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("This is the sceneID: " + leverCounter.sceneID);
        Debug.Log("This is the required number of levers: " + leverCounter.numRequiredLevers);

    }

    protected override void OnInteract()
    {
        if(fakeWallActive){
            base.OnInteract();
            leverSprite.flipX = false; //Flips the lever sprite on the X-axis
            fakeWallActive = false;
            fakeWall.SetActive(!fakeWall.activeSelf);
        }
    }

}
