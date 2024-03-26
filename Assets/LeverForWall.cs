using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverForWall : InteractableObject
{

    [SerializeField] GameObject fakeWall;
    private bool fakeWallActive = true;

    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    protected override void OnInteract()
    {
        if(fakeWallActive){
            base.OnInteract();
            fakeWallActive = false;
            fakeWall.SetActive(!fakeWall.activeSelf);
        }
    }

}
