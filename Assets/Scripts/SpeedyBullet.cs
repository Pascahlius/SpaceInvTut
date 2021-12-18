using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedyBullet : MonoBehaviour
{
    Rigidbody2D rb;
    public float bulletSpeed = 3;
  
    // Start is called before the first frame update
    void Start()
    {
        Vector2 vekMausPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Vector2 vekSpielerPos = GameObject.FindWithTag("Player").transform.position;

        Vector2 vekKugelPos = transform.position;
        
        Vector2 vekGesamt = vekMausPosition - vekKugelPos;
  


        rb = GetComponent<Rigidbody2D>();
        rb.velocity = vekGesamt * bulletSpeed;


        GameObject spieler = GameObject.FindWithTag("Player");
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), spieler.GetComponent<Collider2D>());

        Physics2D.IgnoreLayerCollision(6, 6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
