using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Collider von GameObject einen Collider einer Wand trifft destroy it


public class BorderCollision : MonoBehaviour
{
    Collider2D collidierer;
    Collider2D wandCollider0;
    Collider2D wandCollider1;
    Collider2D wandCollider2;
    Collider2D wandCollider3;
    Collider2D wandCollider4;
    public GameObject[] waende;
    // Start is called before the first frame update
    void Start()
    {
        collidierer = gameObject.GetComponent<Collider2D>();
        waende = GameObject.FindGameObjectsWithTag("Wall");
        
        wandCollider0 = waende[0].GetComponent<Collider2D>();
        wandCollider1 = waende[1].GetComponent<Collider2D>();
        wandCollider2 = waende[2].GetComponent<Collider2D>();
        wandCollider3 = waende[3].GetComponent<Collider2D>();
        wandCollider4 = waende[4].GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {


        if ((collidierer.IsTouching(wandCollider0) || collidierer.IsTouching(wandCollider1) || collidierer.IsTouching(wandCollider2) || collidierer.IsTouching(wandCollider3) ||
        collidierer.IsTouching(wandCollider4)) && gameObject.tag == "BulletPlayer")
         
            {
                Destroy(gameObject);
            }

        if ((collidierer.IsTouching(wandCollider0) || collidierer.IsTouching(wandCollider1) || collidierer.IsTouching(wandCollider2) || collidierer.IsTouching(wandCollider3) ||
        collidierer.IsTouching(wandCollider4)) && gameObject.tag == "BulletEnemy")

        {
            Destroy(gameObject);
        }

        if ((collidierer.IsTouching(wandCollider0) || collidierer.IsTouching(wandCollider1) || collidierer.IsTouching(wandCollider2) || collidierer.IsTouching(wandCollider3)) && gameObject.tag == "Enemy")

        {
            Destroy(gameObject);
        }

    }

}
