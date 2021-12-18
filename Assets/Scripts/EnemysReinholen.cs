using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemysReinholen : MonoBehaviour
{
    public GameObject Enemy1;
    public GameObject Enemy2;
    public float spawnGesamt;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("Enemy1Spawn", 5, 3);
        InvokeRepeating("Enemy2Spawn", 5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Enemy1Spawn()
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-5.0f,5.0f), 12,0);
        Enemy2Spawn(spawnPoint);
 

        Instantiate(Enemy1, spawnPoint, Quaternion.identity);
    }

    public void Enemy2Spawn(Vector3 spawnpoint)
    {
        
        

        Vector3 spawnPoint2 = new Vector3(Random.Range(-5.0f, 5.0f), 12, 0);

        spawnGesamt = spawnpoint.x - spawnPoint2.x;
        


        if ((spawnGesamt) < 0)
        {
            spawnGesamt *= (-1);
        } 
        

        while (spawnGesamt < 2)
        {
            spawnPoint2.x = Random.Range(-5.0f, 5.0f);

            spawnGesamt = spawnpoint.x - spawnPoint2.x;

            if ((spawnGesamt) < 0)
            {
                spawnGesamt *= (-1);
            }

            if (spawnGesamt >= 2)
            {
                break;
            }
        }
        
        

        Instantiate(Enemy2, spawnPoint2, Quaternion.identity);
    }
}
