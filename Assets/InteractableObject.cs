using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : CollidableObject
{
    //Indicates whether player has interacted with the given object
    //Prevents spamming the interaction key
    private bool zInteracted = false;


    //OnCollided overrides the function from its parent, CollidableObject
   protected override void OnCollided(GameObject collidedObject){
       if(Input.GetKey(KeyCode.E)){
            OnInteract();
       }
    }

    protected virtual void OnInteract(){
        if(!zInteracted){
            zInteracted = true;
            Debug.Log("INTERACT WITH " + name);
        }
    }
}
