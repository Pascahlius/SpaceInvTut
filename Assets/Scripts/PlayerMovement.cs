using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;
    Rigidbody2D rb2d;
    Animator animatorMovement;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animatorMovement = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2 (h, v);

        rb2d.velocity = dir.normalized * speed;

        animatorMovement.SetBool("isFlyingLeft", h < 0);
        animatorMovement.SetBool("isFlyingRight", h > 0);
        animatorMovement.SetBool("isFlyingUp", v > 0);
        animatorMovement.SetBool("isFlyingDown", v < 0);

    }
}
