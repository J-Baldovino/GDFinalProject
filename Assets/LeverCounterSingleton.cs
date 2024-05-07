using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverCounterSingleton : MonoBehaviour
{
    public static LeverCounterSingleton singleton;
    public int leversActivated = 0;

    void Awake(){
        if(singleton == null){
            singleton = this;
        }else{
            Destroy(this.gameObject);
        }

    }
}
