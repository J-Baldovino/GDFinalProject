using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    [SerializeField] float speed = 5.0f;

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
}
