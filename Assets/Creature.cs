using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{

    //NOTE: It may be a could idea to prevent the variable from being public
    [SerializeField] public float speed = 5.0f;
    [SerializeField] GameObject body;
    [SerializeField] List<AnimationStateChanger> animationStateChangers;

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
        if(direction.x != 0 || direction.y != 0){
            foreach(AnimationStateChanger asc in animationStateChangers){
                asc.ChangeAnimationState("Walk", speed);
            }
        }else{
            foreach(AnimationStateChanger asc in animationStateChangers){
                asc.ChangeAnimationState("Idle");
            }
        }

        rb.velocity = (direction * speed);
        if(rb.velocity.x < 0){
            body.transform.localScale = new Vector3(-1,1,1);
        }else if(rb.velocity.x > 0){
            body.transform.localScale = new Vector3(1,1,1);
        }
    }

    public void CollectSpeedItem(){
        speed += Random.Range(1,3);
        GetComponent<AudioSource>().Play();
    }
}
