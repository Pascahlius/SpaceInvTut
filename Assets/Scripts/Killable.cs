using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour
{
    public Canvas Ende;
    public GameObject Spawnpoint;
    public static int lebensbar = 3;

    public Canvas verlorenScreen;


    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this);
       
        Spawnpoint = GameObject.Find("SpawnpointEnemy");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "BulletEnemy")
        {
            

            Destroy(Spawnpoint);

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemies.Length; i++)
            {
                Destroy(enemies[i]);
            }

            GameObject[] bulletenemies = GameObject.FindGameObjectsWithTag("BulletEnemy");
            for (int i = 0; i < bulletenemies.Length; i++)
            {
                Destroy(bulletenemies[i]);
            }

            gameObject.SetActive(false);
            

            Lebensanzeige.lebenszaehler--;

            Debug.Log(Lebensanzeige.lebenszaehler);


            if(Lebensanzeige.lebenszaehler > 0)
            {
                Instantiate(Ende);
            } else if (Lebensanzeige.lebenszaehler == 0)
            {
                Instantiate(verlorenScreen);
            }
           



        }
    }
}
