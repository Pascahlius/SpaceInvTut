using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyBulletController : MonoBehaviour
{
    public GameObject bulletEnemy;
    public GameObject Enemy;
    public float startzeit = 3f;
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", startzeit, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShootBullet()
    {
        Vector2 vek2 = new Vector2(transform.position.x, (transform.position.y) - 1.6f);
        Instantiate(bulletEnemy, vek2, Quaternion.identity);
    }
}
