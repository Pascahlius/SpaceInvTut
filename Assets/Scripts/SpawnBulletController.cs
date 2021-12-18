using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{

    public GameObject bullet;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
      

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 vek2 = transform.position;
            vek2.x = vek2.x - 0.05f;
            vek2.y = vek2.y + 1.2f;
            GameObject bulletg = Instantiate(bullet, vek2, Quaternion.identity);

            //Vector2 vek2Bullet = bullet.transform.position - transform.position;

           // bulletg.GetComponent<Rigidbody2D>().velocity = vek2Bullet.normalized * bulletSpeed;

        }
    }


}
