using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Creature>() != null){
            other.GetComponent<Creature>().CollectSpeedItem();
            Destroy(this.gameObject);
        }
    }
}
