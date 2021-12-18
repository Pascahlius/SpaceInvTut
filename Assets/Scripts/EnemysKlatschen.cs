using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysKlatschen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "BulletEnemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
