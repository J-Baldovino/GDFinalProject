using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverForWall : InteractableObject
{
    [SerializeField] GameObject fakeWall;
    private bool fakeWallActive = true;
    SpriteRenderer leverSprite;

    void Awake(){
        leverSprite = GetComponent<SpriteRenderer>();
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
