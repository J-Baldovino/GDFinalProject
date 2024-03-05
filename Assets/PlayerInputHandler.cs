using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{

    [SerializeField] Creature playerCreature;

    [SerializeField] Vector2 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Vector3 input = Vector3.zero;

        // if(Input.GetKey(KeyCode.A)){
        //     input.x += -1;
        // }

        // if(Input.GetKey(KeyCode.D)){
        //     input.x += 1;
        // }

        // if(Input.GetKey(KeyCode.S)){
        //     input.y += -1;
        // }

        // if(Input.GetKey(KeyCode.W)){
        //     input.y += 1;
        // }

        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        playerCreature.MoveCreatureRb(movementDirection);
    }
}
