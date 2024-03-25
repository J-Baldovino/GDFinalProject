using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    //NOTE: It may be a could idea to prevent the variable from being public
    [SerializeField] public float speed = 5.0f;

    [Header("Tracked Data")]
    [SerializeField] Vector3 homePosition = Vector3.zero;

    //Allows the creature to be affected by physics
    Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCreatureRb(Vector3 direction){
        rb.velocity = (direction * speed);
    }

    public void CollectSpeedItem(){
        speed += Random.Range(5,8);
        GetComponent<AudioSource>().Play();
    }
}
