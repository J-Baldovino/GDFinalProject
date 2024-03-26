using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidableObject : MonoBehaviour
{
    private Collider2D zCollider;
    [SerializeField] private ContactFilter2D zFilter;
    private List<Collider2D> zCollidedObjects = new List<Collider2D>(1);

    protected virtual void Start(){
        zCollider = GetComponent<Collider2D>();
    }

    protected virtual void Update(){
        zCollider.OverlapCollider(zFilter, zCollidedObjects);

        foreach(var i in zCollidedObjects){
            OnCollided(i.gameObject);
        }
    }

    protected virtual void OnCollided(GameObject collidedObject){
        Debug.Log("Collided with " + collidedObject.name);
    }
}
