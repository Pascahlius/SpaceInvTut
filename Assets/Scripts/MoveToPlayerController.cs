using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject spielerObjekt = GameObject.FindWithTag("Player");
     
           Vector3 vek3 = (spielerObjekt.transform.position - transform.position).normalized;
           Vector2 vek2 = new Vector2(vek3.x, vek3.y);
           GetComponent<Rigidbody2D>().velocity = vek2 * speed;
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
