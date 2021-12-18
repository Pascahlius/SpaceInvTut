using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lebensanzeige : MonoBehaviour
{
    public SpriteRenderer Herz1;
    public SpriteRenderer Herz2;
    
    public SpriteRenderer Herz3;
    public GameObject Spieler;

    public static int lebenszaehler = 3;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        if (lebenszaehler == 2)
        {
            Destroy(Herz3);
        }

        if (lebenszaehler == 1)
        {
            Destroy(Herz2);
            Destroy(Herz3);
        }

        if (lebenszaehler == 0)
        {
            Destroy (Herz1);
           Destroy(Herz2);
            Destroy (Herz3);
        }
    }

}
