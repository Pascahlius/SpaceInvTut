using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    //public Transform spielerPos;
    public float bullenemySpeed;
    Rigidbody2D rb2D;
    Vector2 beschleunigung;

    // Start is called before the first frame update
    void Start()
    {
        beschleunigung = new Vector2(0, - bullenemySpeed);
        rb2D = GetComponent<Rigidbody2D>();
       /* spielerPos = GetComponent<Transform>();

        Vector2 vekMaus = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 vekSpieler = new Vector2(spielerPos.position.x, spielerPos.position.y);
        Vector2 vekGesamt = vekMaus - vekSpieler;
       */
    }

    // Update is called once per frame
    void Update()
    {
        rb2D.velocity = beschleunigung;
    }
}
