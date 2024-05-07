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
        Debug.Log(LeverCounterSingleton.singleton.leversActivated);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        playerCreature.MoveCreatureRb(movementDirection);
    }
}
